using Spectre.Console;
using Exercise;


void run() {
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
    Menu.runExercise(selection);

    if(AnsiConsole.Confirm("Retornar para o menu?")) {
        run();
    } else {
        AnsiConsole.WriteLine("Até mais! :) ");
    }
}

run();