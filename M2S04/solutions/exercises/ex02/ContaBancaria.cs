using Spectre.Console;
using System.Globalization;

namespace Exercise02;

public class ContaBancaria
{
    private string NumeroDaConta;
    private decimal Saldo = 0m;
    private CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");

    public ContaBancaria()
    {
        GerarNumeroDaConta();
    }

    public void Depositar() {
        decimal valor = AnsiConsole.Prompt(
            new TextPrompt<decimal>("Insira o [green]valor[/] para depositar: ")
                .PromptStyle("green")
                .ValidationErrorMessage("[red]Insira um valor válido[/]")
                .Validate(valor =>
                {
                    return valor switch
                    {
                        <= 0m => ValidationResult.Error("[red]O valor não pode ser menor que 0.[/]"),
                        >= 10000m => ValidationResult.Error("[red]Você só pode depositar no máximo 10000 por vez.[/]"),
                        _ => ValidationResult.Success(),
                    };
                }));
        
        Saldo += valor;


        AnsiConsole.MarkupLine($"O valor de [green]" + valor.ToString("C", culture) + $" [/]foi depositado na conta {this.NumeroDaConta}");
    }

    public void Sacar() {
        decimal valor = AnsiConsole.Prompt(
            new TextPrompt<decimal>("Insira o [red]valor[/] para sacar: ")
                .PromptStyle("red")
                .ValidationErrorMessage("[red]Insira um valor válido[/]")
                .Validate(valor =>
                {
                    return valor switch
                    {
                        <= 0m => ValidationResult.Error("[red]O valor não pode ser menor que 0.[/]"),
                        >= 10000m => ValidationResult.Error("[red]Você só pode sacar no máximo 10000 por vez.[/]"),
                        _ => ValidationResult.Success(),
                    };
                }));
        
        Saldo -= valor;

        AnsiConsole.MarkupLine($"O valor de [red]" + valor.ToString("C", culture) + $" [/]foi sacado da conta  [purple4_1]{this.NumeroDaConta}[/]");

    }

    public void GetSaldo() {
        AnsiConsole.MarkupLine($"A conta de número [purple4_1]{this.NumeroDaConta}[/] tem o saldo de [aquamarine1]" + Saldo.ToString("C", culture) + "[/]");
    }

    public void GerarNumeroDaConta() {
        var random = new Random();
        var algorismos = "0123456789";
        
        NumeroDaConta = Enumerable.Repeat(algorismos, 10)
                        .Select(s => s[random.Next(s.Length)])
                        .Aggregate("", (s, c) => s + c);
    }

    public string GetNumeroDaConta() {
        return NumeroDaConta;
    }
}
