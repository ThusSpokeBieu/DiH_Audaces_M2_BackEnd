namespace ConsoleExercise
{

    class Exercise08 : ExerciseBase
    {
        private Exercise05 otherExercise = new Exercise05();
        private int[] numbers = new int[5];

        public override void execute()
        {
            Console.WriteLine("\n \t Executando exercicio 8...");

            Console.WriteLine("\n \t Defina cinco números e o programa vai imprimir o maior.");

            this.otherExercise.setTodosNumeros();

            this.numbers = this.otherExercise.getNumbers();

            Array.Sort(this.numbers);

            Console.Write("\n \t O maior número é: ");

            Console.Write(this.numbers[this.numbers.Count() -1]);

            Console.ReadKey();
        }
    }
}

/* 
Imprima o maior número da lista

Crie um programa que solicite ao usuário que digite cinco números inteiros e armazene esses números em um array. Em seguida, exiba na tela o maior número digitado.
*/