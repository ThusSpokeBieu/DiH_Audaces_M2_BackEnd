namespace ConsoleExercise
{
    
    class Exercise05 : ExerciseBase
    {
        private int[] numeros = new int[5];

        private void setTodosNumeros() {
            for (int i = 0; i < this.numeros.Length; i++)
                {
                    Console.Write("\n \t Insira o {0}º número: ", i + 1);
                    this.setNumero(i);
                }
        }

        private void setNumero(int index) {
            int numero;
            if (!int.TryParse(Console.ReadLine(), out numero)) {
                Console.Write("\n \t Por favor, insira um número válido: ");
                this.setNumero(index);
            } else {
                this.numeros[index] = numero;
            }
        }

        private void imprimirNumeros() {
            Array.Sort(this.numeros);

            for (int i = 0; i < this.numeros.Length; i++)
                {
                    Console.Write("\n \t O {0}º número é: ", i + 1);
                    Console.Write(this.numeros[i]);
                }
            
            Console.WriteLine();
            Console.ReadKey();
        }

        public override void execute()
        {
            Console.Clear();
            Console.WriteLine("\n \t Executando exercicio 5...");

            Console.Write(" \n \t Digite cinco números, e o programa irá imprimi-los em ordem crescente");

            this.setTodosNumeros();

            Console.Write(" \n \t Os números em ordem crescente são:");

            this.imprimirNumeros();
        }
    }
}

/*
Crie um programa que leia 4 números e faça a ordenação entre eles.

Passo a passo:

Declare um array de inteiros chamado "numeros", que vai armazenar os 4 números digitados pelo usuário;

Com o laço for peça que o usuário digite cada um dos 4 números, armazenando-os no array "numeros" através da posição i;

Use o método Sort da classe Array para ordenar o array "numeros" em ordem crescente;

Imprima os números ordenados na tela, usando um novo laço for.
*/