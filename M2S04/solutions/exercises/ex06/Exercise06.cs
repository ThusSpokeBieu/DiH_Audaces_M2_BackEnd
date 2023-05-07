using Spectre.Console;
using Exercise06;

namespace Exercise;
class Exercise06 : ExerciseBase
{
  public override void execute()
  {
    AnsiConsole.WriteLine("Rodando exercício 6");
    AnsiConsole.WriteLine("Insira os dados de um retangulo: ");
    var Retangulo = new Retangulo();
    Retangulo.CalcularArea();
    Console.ReadKey();
  }
}