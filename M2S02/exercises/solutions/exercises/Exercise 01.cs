namespace ConsoleExercise
{
    class Exercise01 : ExerciseBase
    {
        public int number1;
        public int number2;
        public int result;

        private void setNumber1() {
            if (!int.TryParse(Console.ReadLine(), out this.number1)) {
                Console.Write("\t Por favor, insira um número inteiro válido: ");
                setNumber1();
            }
        }

        private void setNumber2() {
            if (!int.TryParse(Console.ReadLine(), out this.number2)) {
                Console.Write("\t Por favor, insira um número inteiro válido: ");
                setNumber2();
            }
        }

        private int setResult() {
            this.result = this.number1 + this.number2;
            return this.result;
        }
        public override void execute() {
            Console.Clear();
            Exercise01 exercise = new Exercise01();

            Console.Write(
                "\n \t Exercício 1 - Some dois números!" +
                "\n \n \t Escolha o primeiro número: "
                );
            
            exercise.setNumber1();

            Console.Write(
                "\n \t Digite o segundo número: "
            );

            exercise.setNumber2();

            Console.Write(
                "\n \t O resultado da soma: " + 
                exercise.number1 + " + " + exercise.number2 +
                " = " + exercise.setResult() + "\n \n \n"
                );

        }
    }
}

