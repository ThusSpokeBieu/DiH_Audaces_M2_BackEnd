using Spectre.Console;
using Exercise08;

namespace Exercise;

class Exercise08 : ExerciseBase
{
  private Cachorro _cachorro = new Cachorro();
  private Gato _gato = new Gato();

  public override void execute()
    {
        AnsiConsole.Clear();
        AnsiConsole.WriteLine("Rodando exercício 8...");
        AnsiConsole.WriteLine();
        var selectionList = new List<String>();
            selectionList.Add("Ouvir Gato");
            selectionList.Add("Ouvir Cachorro");
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
                    _gato.EmitirSom();
                    Console.ReadKey();
                    execute();
                    break;
                case 1: 
                    _cachorro.EmitirSom();
                    Console.ReadKey();
                    execute();
                    break;
                default:
                    break;
            }
    }
}