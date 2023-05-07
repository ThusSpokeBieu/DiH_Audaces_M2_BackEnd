using Spectre.Console;

namespace Exercise08;

public class Gato : Animal
{
  public override void EmitirSom()
  {
    AnsiConsole.MarkupLine("[green]Miau![/]");
  }
}
