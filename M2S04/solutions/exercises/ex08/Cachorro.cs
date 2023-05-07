using Spectre.Console;

namespace Exercise08;

public class Cachorro : Animal
{
  public override void EmitirSom()
  {
    AnsiConsole.MarkupLine("[green]Au! Au![/]");
  }
}
