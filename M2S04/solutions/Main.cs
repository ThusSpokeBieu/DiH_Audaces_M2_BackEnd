using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;

namespace Exercise
{
    public class Main
    {
        public static void Run() {
            var Menu = new ExerciseMenu();
            var ExerciseList = Menu.Exercises.Select( e => $"{e.name} - {e.description}").ToArray();
            AnsiConsole.Clear();

            AnsiConsole.Write(
                new FigletText("C# Exercises")
                    .Centered()
                    .Color(Color.Green));

            AnsiConsole.Write(
                new FigletText("Semana 4")
                    .Centered()
                    .Color(Color.Yellow));

            var menuSelection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Lista de Exercícios: ")
                    .PageSize(5)
                    .MoreChoicesText("[grey]Use as setas para selecionar o exercicio[/]")
                    .AddChoices(ExerciseList));

            var selection = Array.IndexOf(ExerciseList, menuSelection);
            Menu.RunExercise(selection);

        }

    }
}