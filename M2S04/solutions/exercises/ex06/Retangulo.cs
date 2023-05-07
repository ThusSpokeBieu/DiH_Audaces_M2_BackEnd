using Spectre.Console;

namespace Exercise06;

public class Retangulo
{
    private Double _largura;
    private Double _altura;

    public Retangulo() {
      _largura = AnsiConsole.Ask<double>("Insira a [blue]largura[/] do retangulo: ");
      _altura = AnsiConsole.Ask<double>("Insira a [red]altura[/] do retangulo: ");
    }

    public void CalcularArea() {
      Double area = _largura * _altura;
      AnsiConsole.MarkupLine($"A [green]area[/] do retângulo é de: [green]{area}[/]");
    }
}
