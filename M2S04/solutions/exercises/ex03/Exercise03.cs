using Spectre.Console;
using Exercise03;

namespace Exercise;
class Exercise03 : ExerciseBase
{
  public ContaBancaria? Conta;

  public override void execute()
    {
        AnsiConsole.Clear();
        AnsiConsole.WriteLine("Rodando exercício 3...");
        AnsiConsole.WriteLine();
        AnsiConsole.MarkupLine("Conta Bancária, operações: ");

        var selectionList = new List<String>();
            selectionList.Add("Criar Nova Conta");
            selectionList.Add("Exibir Dados da Conta");
            selectionList.Add("Depositar na Conta");
            selectionList.Add("Sacar da Conta");
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
                    CriarConta();
                    Console.ReadKey();
                    execute();
                    break;
                case 1: 
                    ExibirDados();
                    Console.ReadKey();
                    execute();
                    break;
                case 2: 
                    Depositar();
                    Console.ReadKey();
                    execute();
                    break;
                case 3: 
                    Sacar();
                    Console.ReadKey();
                    execute();
                    break;
                default:
                    break;
            }
    }

    public void CriarConta() {
      if (Conta != null) {
        if (AnsiConsole.Confirm("Já existe uma conta cadastrada, gostaria de sobrescrever ela?"))
            {
                Conta = null;
                AnsiConsole.MarkupLine("Ok! Conta Removida. Tecle qualquer tecla para voltar ao menu.");
            }
      } else {
        var name = AnsiConsole.Ask<string>("Insira o [purple]NOME[/] do cliente: ");
        var cpf = ValidarCpf();

        Conta = new ContaBancaria(name, cpf);
        AnsiConsole.MarkupLine("Conta criada! Tecle qualquer tecla para voltar ao menu.");
      }
    }

    public void ExibirDados() {
      if (Conta == null) {
        AnsiConsole.MarkupLine("Crie uma conta antes de ver os dados!");
      } else {
        Conta.ExibirDados();
      }
    }

    public void Depositar() {
      if (Conta == null) {
        AnsiConsole.MarkupLine("Crie uma conta antes de depositar!");
      } else {
        Conta.Depositar();
      }
    }

    public void Sacar() {
      if (Conta == null) {
        AnsiConsole.MarkupLine("Crie uma conta antes de sacar!");
      } else {
        Conta.Sacar();
      }
    }

    public String ValidarCpf() {
      var cpfRegex = new System.Text.RegularExpressions.Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
      return AnsiConsole.Prompt(
            new TextPrompt<string>("Insira o [darkorange3_1]CPF[/] do cliente: ")
                .PromptStyle("darkorange3_1")
                .ValidationErrorMessage("[red]Insira um CPF válido[/]")
                .Validate(valor => cpfRegex.IsMatch(valor) 
                      ? ValidationResult.Success()
                      : ValidationResult.Error("CPF inválido!")));
    }
}