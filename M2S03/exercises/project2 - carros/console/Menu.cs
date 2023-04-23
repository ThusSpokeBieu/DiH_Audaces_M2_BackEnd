using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;

namespace carros.console
{
    public class Menu
    {
        public static string Show() {
            return AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Por favor, selecione uma opção")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Utilize as setas para escolher)[/]")
                    .AddChoices(new[] {
                        "Ver carros", "Adicionar Carros", "Sair"
                    }));
        }
    }
}