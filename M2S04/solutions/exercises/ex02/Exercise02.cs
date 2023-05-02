using Spectre.Console;
using Exercise02;

namespace Exercise;

class Exercise02 : ExerciseBase
{
    private ContaBancaria Conta = new ContaBancaria();
    public override void execute()
    {
        AnsiConsole.Clear();
        AnsiConsole.WriteLine("Rodando exercício 2...");
        AnsiConsole.WriteLine();
        AnsiConsole.MarkupLine("Número de Conta: [purple4_1]" + Conta.GetNumeroDaConta() + "[/]");

        var selectionList = new List<String>();
            selectionList.Add("Ver saldo");
            selectionList.Add("Depositar");
            selectionList.Add("Sacar");
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
                    Conta.GetSaldo();
                    Console.ReadKey();
                    execute();
                    break;
                case 1: 
                    Conta.Depositar();
                    Console.ReadKey();
                    execute();
                    break;
                case 2: 
                    Conta.Sacar();
                    Console.ReadKey();
                    execute();
                    break;
                default:
                    break;
            }
    }
}

