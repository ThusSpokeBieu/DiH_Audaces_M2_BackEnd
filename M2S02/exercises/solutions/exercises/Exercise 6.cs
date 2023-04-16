namespace ConsoleExercise
{
    
    class Exercise6 : ExerciseBase
    {
        String frase = " A linguagem de programação C# é muito poderosa";
        public override void execute()
        {
            Console.Clear();
            Console.WriteLine("\"" + frase + "\" \n Diante dessa frase:");
            List<string> palavras = frase.Split(' ').ToList();
            int tamanho = palavras.Count();

            Console.WriteLine("\n\nDigite a posição da palavra que quer descobrir, por exemplo: \n" +
            "Digitar 8 imprime: " + palavras[tamanho - 1] + "\n");

            int.TryParse(Console.ReadLine(), out int position);

            if(position < 1 || position > tamanho) {
                Console.WriteLine("Digite um número correto!");
                Console.ReadKey();
                this.execute();
            } else {
                Console.WriteLine(palavras[position - 1]);
            }

        }
    }
}

/*
Separando palavras em uma lista

Declare uma variável do tipo string chamada "frase" e atribua a ela a seguinte frase: "A linguagem de programação C# é muito poderosa".
Em seguida, crie uma lista de string chamada palavras e separe as palavras em cada posição da lista.
Depois, exiba apenas a palavra "poderosa" na tela.
*/