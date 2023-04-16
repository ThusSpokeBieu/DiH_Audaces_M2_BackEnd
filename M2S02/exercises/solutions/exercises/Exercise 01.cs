namespace ConsoleExercise
{
    class Exercise01 : ExerciseBase
    {
        private int number1;
        private int number2;
        private int result;

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

            Console.Write(
                "\n \t Exercício 1 - Some dois números!" +
                "\n \n \t Escolha o primeiro número: "
                );
            
            this.setNumber1();

            Console.Write(
                "\n \t Digite o segundo número: "
            );

            this.setNumber2();

            Console.Write(
                "\n \t O resultado da soma: " + 
                this.number1 + " + " + this.number2 +
                " = " + this.setResult() + "\n \n \n"
                );

        }
    }
}

/*
Faça um programa que leia o nome e a idade do paciente e como resultado mostre o nome do paciente. E a mensagem se é menor ou maior de idade e se é idoso.
*/ 