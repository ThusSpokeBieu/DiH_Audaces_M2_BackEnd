using Spectre.Console;

namespace Exercise
{
    class Exercise04 : ExerciseBase
    {
        public override void execute()
        {
            AnsiConsole.WriteLine("Exercicio 4 foi resolvido no Exercicio 3");
            Console.ReadKey();
            var exercise3 = new Exercise03();
            exercise3.execute();
        }
    }

}