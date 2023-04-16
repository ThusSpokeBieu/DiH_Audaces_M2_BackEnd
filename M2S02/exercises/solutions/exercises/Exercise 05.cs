namespace ConsoleExercise
{
    
    class Exercise05 : ExerciseBase
    {
        List<int> numeros = new List<int>();

        public override void execute()
        {
            Console.WriteLine("Executando exercicio 5...");
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