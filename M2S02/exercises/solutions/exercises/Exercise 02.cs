namespace ConsoleExercise
{
    
    class Exercise02 : ExerciseBase
    {
        private int number;

        private void verifyNumber() {
    
            if (!int.TryParse(Console.ReadLine(), out this.number)) {
                Console.Write("\t Por favor, insira um número inteiro e válido: ");
                verifyNumber();
                return;
            };

            Console.Write($"\n \t O número {this.number} é um número");

            if (this.number % 2 != 0) {
                Console.Write(" impar. \n");
            } else {
                Console.Write(" par. \n");
            }
        }
        public override void execute()
        {
            Console.Clear();
            Console.WriteLine("\t Executando exercicio 2!");
            Console.Write("\n \t Por favor, insira um número e descobriremos se ele é par ou impar: ");
            this.verifyNumber();
        }
    }
}