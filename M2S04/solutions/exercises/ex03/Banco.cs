using System.Globalization;
using Spectre.Console;

namespace Exercise03;

public class Banco
{
    private Decimal _saldo = 0m;
    private CultureInfo _culture = CultureInfo.CreateSpecificCulture("pt-BR");

    public override String ToString() {
        return _saldo.ToString("C", _culture);
    }

    public void Depositar(Decimal valor) {
        _saldo += valor;
        AnsiConsole.MarkupLine("O valor de [green]" +
            valor.ToString("C", _culture) + "[/] foi depositado.");
    }

    public void Sacar(Decimal valor) {
        if (valor < _saldo) {
            AnsiConsole.MarkupLine("[red]ERROR:[/] Valor menor que o saldo");
        } else {
            _saldo -= valor;
            AnsiConsole.MarkupLine("O valor de [red]" +
                valor.ToString("C", _culture) + "[/] foi sacado");
        }

    }
}