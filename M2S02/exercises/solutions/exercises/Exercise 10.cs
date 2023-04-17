namespace ConsoleExercise
{
    
    class Exercise10 : ExerciseBase
    {
        public double firstNumber;
        public double secondNumber;

        public void setFirstNumber() {
            Console.Write("\n \t Digite o primeiro número para a operação: ");
            if (!double.TryParse(Console.ReadLine(), out this.firstNumber)) {
                Console.Write("\n \t Por favor, insira um número válido: ");
                this.setFirstNumber();
            }
        }

        public void setSecondNumber() {
            Console.Write("\n \t Digite o segundo número para a operação: ");
            if (!double.TryParse(Console.ReadLine(), out this.secondNumber)) {
                Console.Write("\n \t Por favor, insira um número válido: ");
                this.setSecondNumber();
            }
        }

        private void sumNumbers() {
            Exercise10 exercise = new Exercise10();

            Console.WriteLine("\n \t ########## SOMA ##########");

            exercise.setFirstNumber();
            exercise.setSecondNumber();
            double sum = exercise.firstNumber + exercise.secondNumber;
            Console.Write($"\n \t O resultado da soma {exercise.firstNumber} + {exercise.secondNumber} = {sum}");
            Console.WriteLine("\n \t Presione qualquer tecla para sair...");
            Console.ReadKey();
        }

        private void subtractNumbers() {
            Exercise10 exercise = new Exercise10();

            Console.WriteLine("\n \t ########## SUBTRAÇÃO ##########");


            exercise.setFirstNumber();
            exercise.setSecondNumber();
            double subtraction = exercise.firstNumber - exercise.secondNumber;
            Console.Write($"\n \t O resultado da subtração {exercise.firstNumber} - {exercise.secondNumber} = {subtraction}");
            Console.WriteLine("\n \t Presione qualquer tecla para sair...");
            Console.ReadKey();
        }

        private void multipleNumbers() {
            Exercise10 exercise = new Exercise10();

            Console.WriteLine("\n \t ########## MULTIPLICAÇÃO ##########");

            exercise.setFirstNumber();
            exercise.setSecondNumber();
            double multiplication = exercise.firstNumber * exercise.secondNumber;
            Console.Write($"\n \t O resultado da multiplicação {exercise.firstNumber} * {exercise.secondNumber} = {multiplication}");
            Console.WriteLine("\n \t Presione qualquer tecla para sair...");
            Console.ReadKey();
        }

        private void divideNumbers() {
            Exercise10 exercise = new Exercise10();

            Console.WriteLine("\n \t ########## MULTIPLICAÇÃO ##########");

            exercise.setFirstNumber();
            exercise.setSecondNumber();

            if (exercise.secondNumber == 0) {
                Console.Write("\t O número 0 não é divisivel, selecione outro. ");
                exercise.setSecondNumber();
            } else {
                double division = exercise.firstNumber / exercise.secondNumber;
                Console.Write($"\n \t O resultado da multiplicação {exercise.firstNumber} / {exercise.secondNumber} = {division}");
                Console.WriteLine("\n \t Presione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }

        private void calculatorMenu() {
                Console.Clear();
                Console.WriteLine("\t ########## Menu da Calculadora ##########");
                Console.WriteLine("\t 1. Adição");
                Console.WriteLine("\t 2. Subtração");
                Console.WriteLine("\t 3. Multiplicação");
                Console.WriteLine("\t 4. Divisão");
                Console.WriteLine("\t 0. Sair");
                Console.Write("\t Escolha uma operação: ");

                int.TryParse(Console.ReadLine(), out int option);

                switch (option)
                {
                    case 1:
                        this.sumNumbers();
                        break;
                    case 2:
                        this.subtractNumbers();
                        break;
                    case 3:
                        this.multipleNumbers();
                        break;
                    case 4:
                        this.divideNumbers();
                        break;
                    case 0:
                        Console.WriteLine("Saindo da calculadora...");
                        Console.WriteLine("\n \t Presione qualquer tecla para sair...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente");
                        Console.ReadKey();
                        this.calculatorMenu();
                        break;
                }
            }
            
        public override void execute()
        {
            Console.WriteLine("Executando exercicio 10...");
            this.calculatorMenu();
        }
    }
}

/*

Desenvolva um programa em C# que simule uma calculadora simples.

O programa deve exibir um menu para o usuário com as operações de soma, subtração, multiplicação e divisão.

O programa deve solicitar dois números ao usuário e, em seguida, realizar a operação escolhida.

Caso a operação escolhida seja a divisão, o programa deve verificar se o segundo número é igual a zero e informar ao usuário que não é possível dividir por zero.

O programa deve continuar executando até que o usuário escolha a opção de sair.

Ao final, o programa deve exibir uma mensagem de agradecimento ao usuário por utilizar a calculadora.
*/