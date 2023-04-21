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
            CarTable.Show();
            Menu.Show();
        }
    }
}