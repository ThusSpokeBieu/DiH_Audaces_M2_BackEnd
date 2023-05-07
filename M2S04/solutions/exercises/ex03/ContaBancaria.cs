using Spectre.Console;
using System.Globalization;

namespace Exercise03;

public class ContaBancaria
{ 
  private String _numeroDaConta;
  private Cliente _cliente;
  private Banco _banco;
  private CultureInfo _culture = CultureInfo.CreateSpecificCulture("pt-BR");

  public ContaBancaria(string name, string cpf) {
    _numeroDaConta = GerarNumeroDaConta();
    _cliente = new Cliente(name, cpf);
    _banco = new Banco();
  }

  public void ExibirDados() {
    AnsiConsole.Clear();
    var rule = new Rule("[red]Conta Bancaria[/]");
    rule.LeftJustified();
    rule.RuleStyle("dim teal");
    AnsiConsole.Write(rule);
    AnsiConsole.MarkupLine(
      "Número de conta: [teal]" + _numeroDaConta + "[/] \n" +
      "Nome do Cliente: [purple]" + _cliente.Nome() + "[/] \n" +
      "CPF do Cliente: [darkorange3_1]" + _cliente.Cpf() + "[/] \n" +
      "Saldo da Conta: [darkolivegreen2]" + _banco.ToString() + "[/]"
    );
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
                        >= 10000m => ValidationResult.Error("[red]Você só pode sacar no máximo 10000 por vez.[/]"),
                        _ => ValidationResult.Success(),
                    };
                }));
        
    _banco.Depositar(valor);
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
        
    _banco.Sacar(valor);
  }

  public void Sacar(decimal valor) {
    _banco.Depositar(valor);
  }

  public String GerarNumeroDaConta() {
      var random = new Random();
      var algorismos = "0123456789";
        
      return Enumerable.Repeat(algorismos, 10)
                        .Select(s => s[random.Next(s.Length)])
                        .Aggregate("", (s, c) => s + c);
  }
  
}