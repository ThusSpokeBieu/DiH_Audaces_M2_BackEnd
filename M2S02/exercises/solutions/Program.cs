using System;
using System.Collections.Generic;

namespace ConsoleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseMenu menu = new ExerciseMenu();
            menu.ShowMenu();

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
