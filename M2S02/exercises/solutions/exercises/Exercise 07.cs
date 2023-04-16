namespace ConsoleExercise
{
    
    class Exercise07 : ExerciseBase
    {
        private int number;
        private List<int> evenNumbers = new List<int>();

        private void setNumber() {
            if (!int.TryParse(Console.ReadLine(), out this.number) || this.number < 0 ) {
                Console.Write("\n \t Por favor, insira um número inteiro e maior que zero: ");
                this.setNumber();
            }
        }

        private void verifyEvenNumbers() {
            for (int i = 0; i <= this.number; i++) {
                if (i % 2 == 0) {
                    evenNumbers.Add(i);
                }
            }
        }

        private void printNumbers() {
            Console.Write(0);
            for (int i = 1; i < evenNumbers.Count; i++)
            {
                Console.Write(", " + evenNumbers[i]);
            }

            Console.ReadKey();
            Console.WriteLine();
        }

        public override void execute()
        {
            Console.Clear();
            Console.WriteLine("\n \t Executando exercicio 7...");
            Console.WriteLine("\t Insira um número e exibiremos todos números pares até esse número.");

            Console.Write("\t Insira o número: ");

            this.setNumber();

            this.verifyEvenNumbers();

            Console.Write($"\n \t Os números pares até o número {this.number} são: \n \t ");

            this.printNumbers();
        }
    }

}

/*

Crie um programa que solicite ao usuário que insira um número inteiro positivo e exiba todos os números pares de 0 até esse número. Se o número digitado pelo usuário for negativo ou zero, exiba uma mensagem de erro e solicite novamente o número.

Instruções:

Utilize as estruturas condicionais e laços de repetição;

Solicite ao usuário que informe um número inteiro positivo;

Se o número informado pelo usuário for menor ou igual a zero, o programa deve exibir uma mensagem de erro e solicita novamente que o usuário informe um número válido;

Após ter um número válido, use um laço de repetição for para percorrer todos os números pares de 0 até o número informado pelo usuário (incrementando de 2 em 2 a cada iteração) e exiba cada um dos números pares na tela;

Note que o programa não inclui o próprio número informado pelo usuário se ele for ímpar. Por exemplo, se o usuário informar o número 7, o programa exibirá apenas os números 0, 2, 4 e 6;
*/