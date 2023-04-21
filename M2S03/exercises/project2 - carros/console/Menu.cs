using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;

namespace carros.console
{
    public class Menu
    {
        public static void Show() {
            var menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Por favor, selecione uma opção")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Utilize as setas para escolher)[/]")
                    .AddChoices(new[] {
                        "Ver carros", "Adicionar Carros", "Remover Carros", 
                        "Editar carro", "Ver detalhes do dono"
                    }));
        }
    }
}