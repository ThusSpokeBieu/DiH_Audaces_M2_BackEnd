using Spectre.Console;

namespace Exercise05;

public class Pessoa
{
  private string? _nome;
  private int _idade;

  public int Idade { 
    get => _idade; 
  }
  
  public string Nome { 
    get => _nome; 
  }

  public void SetNome() {
    _nome = AnsiConsole.Ask<string>("Insira o nome: ");
  }

  public void SetIdade() {
    _idade = ValidarIdade();
  }

  private int ValidarIdade() {
    return AnsiConsole.Prompt(
            new TextPrompt<int>("Insira a [green]idade[/] da pessoa: ")
                .PromptStyle("green")
                .ValidationErrorMessage("[red]Idade não pode ser menor que 0 ou maior que 130[/]")
                .Validate(valor =>
                {
                    return valor switch
                    {
                        < 0 => ValidationResult.Error("[red]Idade não pode ser menor que 0.[/]"),
                        >= 131 => ValidationResult.Error("[red]Idade não pode ser maior que 130[/]"),
                        _ => ValidationResult.Success(),
                    };
                }));
  }



}
