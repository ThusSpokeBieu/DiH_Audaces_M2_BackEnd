using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;
using carros.repository;
using carros.console;

namespace carros
{
    public class App
    {
        private CarRepository Repo = new CarRepository();
        private CarTable CarTable;
        public void Execute() {
            AnsiConsole.Clear();
            CarTable = new CarTable(Repo.CarList);
            Title.Show();
            
            var Selection = Menu.Show();

            switch (Selection)
            {
                case "Ver carros":
                    CarView();
                    break;
                case "Adicionar Carros":
                    NewCar NewCar = new NewCar();
                    Repo.AddCar(NewCar.Car);
                    Execute();
                    break;
                case "Sair":
                    if (AnsiConsole.Confirm("Tem certeza que quer sair?")) {
                        AnsiConsole.WriteLine("Até mais... :)");
                    } else {
                        Execute();
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Execute();
                    break;
            }
        }

        private void CarView() {
            AnsiConsole.Clear();         
            CarTable.Show();
            if (AnsiConsole.Confirm("Tem certeza que quer voltar ao menu?")) {
                Execute();
            } else {
                CarView();
            }
        }
    }
}