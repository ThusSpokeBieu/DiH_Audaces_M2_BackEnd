using Spectre.Console;
using Exercise09;
namespace Exercise;
class Exercise09 : ExerciseBase
{
  public Decimal Resultado { get; private set; }
  public Decimal[] Numeros = new Decimal[2];
  public override void execute()
  {
    AnsiConsole.Clear();
    AnsiConsole.WriteLine("Rodando exercício 8...");
    AnsiConsole.WriteLine();
    var selectionList = new List<String>();
      selectionList.Add("Somar");
      selectionList.Add("Subtrair");
      selectionList.Add("Multiplicar");
      selectionList.Add("Dividir");
      selectionList.Add("Sair");

    var menuSelection = AnsiConsole.Prompt(
      new SelectionPrompt<string>()
        .Title("\nSelecione uma opção: ")
        .MoreChoicesText("[grey]Use as setas para selecionar a opção[/]")
        .AddChoices(selectionList.ToArray()));
            
    var selected = Array.IndexOf(selectionList.ToArray(), menuSelection);

    switch (selected) 
    {
      case 0:
        DefinirNums();
        Resultado = Calculadora.Somar(Numeros[0], Numeros[1]);
        AnsiConsole.MarkupLine($"O resultado de {Numeros[0]} + {Numeros[1]} = {Resultado}");
        Console.ReadKey();
        execute();
        break;
      case 1: 
        DefinirNums();
        Resultado = Calculadora.Subtrair(Numeros[0], Numeros[1]);
        AnsiConsole.MarkupLine($"O resultado de {Numeros[0]} - {Numeros[1]} = {Resultado}");
        Console.ReadKey();
        execute();
        break;
      case 2: 
        DefinirNums();
        Resultado = Calculadora.Multiplicar(Numeros[0], Numeros[1]);
        AnsiConsole.MarkupLine($"O resultado de {Numeros[0]} * {Numeros[1]} = {Resultado}");
        Console.ReadKey();
        execute();
        break;
      case 3: 
        DefinirNums();
        if (Numeros[1] == 0) {
          AnsiConsole.MarkupLine($"[red]É inválido tentar dividir por zero.[/]");
        } else
        {
          Resultado = Calculadora.Dividir(Numeros[0], Numeros[1]);
          AnsiConsole.MarkupLine($"O resultado de {Numeros[0]} / {Numeros[1]} = {Resultado}");
        }
        Console.ReadKey();
        execute();
        break;
      default:
        break;
      }
  }

  private void DefinirNums() {
    Numeros[0] = InserirNum("primeiro número");
    Numeros[1] = InserirNum("segundo número");
  }

  private Decimal InserirNum(string variavel) {
    return AnsiConsole.Prompt(
            new TextPrompt<Decimal>("Insira o [blue]valor[/] do " + variavel + ": ")
                .PromptStyle("green")
                .ValidationErrorMessage("[red]Insira um valor válido[/]"));
  }
}