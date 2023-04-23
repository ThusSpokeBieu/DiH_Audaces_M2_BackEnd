using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;
using carros.entities;

namespace carros.console
{
    public class NewCar
    {
        public Car Car { get; set; }
        public Owner Owner { get; set; }
        
        public NewCar() {
            AnsiConsole.Clear();
            ShowCarTitle();
            var brand = SetCarBrand();
            var model = SetCarModel();
            var year = SetCarYear();
            var plate = SetCarPlate();
            var color = SetCarColor();
            Console.WriteLine();
            ShowOwnerTitle();
            var name = SetOwnerName();
            var cpf = SetOwnerCpf();
            var telephone = SetOwnerTelephone();
            var birthday = SetOwnerBirthday();
            var gender = SetOwnerGender();

            Owner = new Owner(name, cpf, telephone, birthday, gender);
            Car = new Car(brand, model, year, plate, color, Owner);
        }

        private void ShowCarTitle() {
            var rule = new Rule("[red]Registrar Carro[/]");
            rule.LeftJustified();
            rule.RuleStyle("yellow dim");
            AnsiConsole.Write(rule);
        }

        private void ShowOwnerTitle() {
            var rule = new Rule("[red]Registrar Dono do Carro[/]");
            rule.LeftJustified();
            rule.RuleStyle("yellow dim");
            AnsiConsole.Write(rule);
        }

        private string SetCarBrand() {
            return AnsiConsole.Prompt(
                new TextPrompt<string>("Insira a [green]marca[/] do carro: ")
                    .PromptStyle("green")
                    .ValidationErrorMessage("[red]Insira uma marca válida.[/]")
            );
        }

        private string SetCarModel() {
            return AnsiConsole.Prompt(
                new TextPrompt<string>("Insira o [blue]modelo[/] do carro: " )
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]Insira um modelo válido.[/]")
            );
        }

        private int SetCarYear() {
            return AnsiConsole.Prompt(
                new TextPrompt<int>("Insira o [gray]ano[/] do carro:")
                    .PromptStyle("gray")
                    .ValidationErrorMessage("[red]Insira um ano válido.[/]")
                    .Validate(year =>
                    {
                        return year switch
                        {
                            <= 1800 => ValidationResult.Error("[red]O carro deve ser pelo menos do ano 1800[/]"),
                            >= 2025 => ValidationResult.Error("[red]O carro não deve ter um ano maior que 2025[/]"),
                            _ => ValidationResult.Success(),
                        };
                    }));

        }   

        private string SetCarPlate() {
            return AnsiConsole.Prompt(
                new TextPrompt<string>("Insira a [darkorange3]placa[/] do carro ")
                    .PromptStyle("darkorange3")
                    .DefaultValue("AAA-1111")
                    .DefaultValueStyle("darkorange3")
                    .ShowDefaultValue()
                    .ValidationErrorMessage("[red]Insira uma placa válida.[/]")
                    .Validate(plate =>
                    {
                        return Car.ValidatePlate(plate)
                            ? ValidationResult.Success()
                            : ValidationResult.Error("[red]A placa deve ter o formato AAA-NNNN, sendo A caracteres do alfabeto e N apenas números. Ex. ABC-1234[/]");
                    }));
        }

        private string SetCarColor() {
            return AnsiConsole.Prompt(
                new TextPrompt<string>("Insira a [purple]cor[/] do carro: ")
                    .PromptStyle("purple")
                    .ValidationErrorMessage("[red]Insira uma cor válida.[/]")
            );
        }

        private string SetOwnerName() {
            return AnsiConsole.Prompt(
                new TextPrompt<string>("Insira o [teal]nome[/] do dono: ")
                    .PromptStyle("teal")
                    .ValidationErrorMessage("[red]Insira um nome válido.[/]")
            );
        }

        private string SetOwnerCpf() {
            return AnsiConsole.Prompt(
                new TextPrompt<string>("Insira o [gold1]CPF[/] do dono: ")
                    .PromptStyle("gold1")
                    .DefaultValue("XXX.XXX.XXX-XX")
                    .DefaultValueStyle("gold1")
                    .ShowDefaultValue()
                    .ValidationErrorMessage("[red]Insira um CPF válido.[/]")
                    .Validate(cpf =>
                    {
                        return Owner.ValidateCPF(cpf)
                            ? ValidationResult.Success()
                            : ValidationResult.Error("[red]O CPF deve ter o formato XXX.XXX.XXX-XX, sendo apenas números e a pontuação. Ex.: 012.345.678-90[/]");
                    }));
        }

        private string SetOwnerTelephone() {
            return AnsiConsole.Prompt(
                new TextPrompt<string>("Insira o [fuchsia]telefone[/] do dono: ")
                    .PromptStyle("fuchsia")
                    .DefaultValue("(XX) XXXXX-XXXX")
                    .DefaultValueStyle("fuchsia")
                    .ShowDefaultValue()
                    .ValidationErrorMessage("[red]Insira um número válido.[/]")
                    .Validate(phone =>
                    {
                        return Owner.ValidatePhone(phone)
                            ? ValidationResult.Success()
                            : ValidationResult.Error("[red]O número de telefone tem que ter o formato (XX) XXXXX-XXXX. Ex.: (11) 98745-4321[/]");
                    }));
        }

        private string SetOwnerBirthday() {
               return AnsiConsole.Prompt(
                new TextPrompt<string>("Insira a [mediumpurple3]Data de Nascimento[/] do dono: ")
                    .PromptStyle("mediumpurple3")
                    .DefaultValue("DD/mm/AAAA")
                    .DefaultValueStyle("mediumpurple3")
                    .ShowDefaultValue()
                    .ValidationErrorMessage("[red]Insira uma data válida.[/]")
                    .Validate(date =>
                    {
                        return Owner.ValidateBirthday(date)
                            ? ValidationResult.Success()
                            : ValidationResult.Error("[red]A data deve ter o formato DD/mm/AAAA, dia/mês/ano. Ex.: 01/01/1990[/]");
                    }));
        }

        private string SetOwnerGender() {
            return AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Selecione o [aqua]gênero[/] do dono?")
                    .PageSize(3)
                    .MoreChoicesText("[grey]Use as setas para selecionar[/]")
                    .AddChoices(new[] {
                        "Masculino", "Feminino", "Outro"
                    }));
        }
    }
}