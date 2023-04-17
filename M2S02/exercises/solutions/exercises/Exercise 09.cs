namespace ConsoleExercise
{
    
    class Exercise09 : ExerciseBase
    {
        private List<int> numbers = new List<int>();

        private int numberQuantity;

        private int sum = 0;

        private void setNumberQuantity() {
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 1) {
                Console.Write("\n \t Por favor, insira uma quantidade válida: ");
                this.setNumberQuantity();
            } else {
                this.numberQuantity = quantity;
            }
        }

        private void setAllNumbers() {
            for (int i = 0; i < this.numberQuantity; i++) {
                Console.Write("\n \t Insira o {0}º número: ", i + 1);
                this.setNumber();
            }
        }

        private void setNumber() {
            if (!int.TryParse(Console.ReadLine(), out int number)) {
                Console.Write("\n \t Por favor, insira um número válido: ");
                this.setNumber();
            } else {
                this.numbers.Add(number);
            }
        }

        private void getAverage() {
            foreach (int number in this.numbers) {
                sum += number;
            }

            double average = sum / this.numberQuantity;

            Console.Write(average);
            Console.ReadKey();
            Console.WriteLine();
        }

        public override void execute()
        {
            Console.Clear();

            Exercise09 exercise = new Exercise09();

            Console.WriteLine("\n \t Executando exercicio 9...");
            Console.Write("\n \t Programa para medir médias, selecione uma quantidade de números e depois escolha quais números");
            Console.Write("\n \n \t Quantidade de números: ");

            exercise.setNumberQuantity();

            Console.Write("\n \n \t Selecione os números: ");

            exercise.setAllNumbers();

            Console.Write("\n \n \t A média aritmética desses números é: ");

            exercise.getAverage();
        }
    }
}

/*
Crie um programa que solicite ao usuário que insira a quantidade de números que ele deseja calcular a média aritmética. Em seguida, peça ao usuário para inserir os números um por um. Depois de ter todos os números, calcule a média aritmética e exiba-a na tela.

Instruções:

Utilize de arrays e laços de repetição;

Solicita ao usuário que informe a quantidade de números que ele deseja calcular a média.

Em seguida, crie um array com o tamanho informado pelo usuário.

Depois, em um laço de repetição, solicite ao usuário que insira cada um dos números do array.

Uma vez que todos os números foram inseridos, use outro laço de repetição (um foreach) para somar todos os números do array.

Após ter a soma dos números, calcule a média aritmética dividindo a soma pela quantidade de números e exiba o resultado na tela.

Note que é preciso converter a soma para um tipo double antes de fazer a divisão, para garantir que o resultado da média seja um número com casas decimais.
*/