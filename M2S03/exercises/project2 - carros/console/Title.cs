using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;

namespace carros.console
{
    public class Title
    {
        public static void Show() {
            AnsiConsole.WriteLine();
            AnsiConsole.Write(
                    new FigletText("Car System")
                        .Centered()
                        .Color(Color.Red));
            AnsiConsole.WriteLine();
        }
    }
}