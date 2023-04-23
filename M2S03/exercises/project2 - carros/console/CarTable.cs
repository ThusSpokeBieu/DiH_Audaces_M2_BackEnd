using Spectre.Console;
using carros.entities;

namespace carros.console
{
    public class CarTable
    {
        Table table = new Table();
        public CarTable(List<Car> carList) {
            table.Title("Carros Cadastrados");
            int id = 1;

            table.HeavyBorder();
            table.Border(TableBorder.Rounded);
            table.AddColumn(new TableColumn("[bold]ID[/]").Centered());
            table.AddColumn(new TableColumn("[bold]MARCA[/]").Centered());
            table.AddColumn(new TableColumn("[bold]MODELO[/]").Centered());
            table.AddColumn(new TableColumn("[bold]ANO[/]").Centered());
            table.AddColumn(new TableColumn("[bold]PLACA[/]").Centered());
            table.AddColumn(new TableColumn("[bold]COR[/]").Centered());
            table.AddColumn(new TableColumn("[bold]NOME DO DONO[/]").Centered());
            table.AddColumn(new TableColumn("[bold]CPF DO DONO[/]").Centered());

            carList.ForEach(car => {
                table.AddRow(
                    $"{id++}",
                    $"[green]{car.Brand}[/]", 
                    $"[blue]{car.Model}[/]",
                    $"[gray]{car.Year.ToString()}[/]",
                    $"[darkorange3]{car.Plate}[/]",
                    $"[purple]{car.Color}[/]",
                    $"[teal]{car.Owner.Name}[/]",
                    $"[gold1]{car.Owner.CPF}[/]");
            });
        }                

        public void Show() {
            AnsiConsole.WriteLine();
            AnsiConsole.Write(table.Centered());
            AnsiConsole.WriteLine();
        }
    }
}