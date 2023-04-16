namespace ConsoleExercise
{
    
    class Exercise03 : ExerciseBase
    {

        private String name;
        private int age;

        private void setName() {
            this.name = Console.ReadLine();

            if (this.name.Any(char.IsDigit) || this.name.Length < 2) {
                Console.Write("\n \t Por favor, insira um nome válido: ");
                setName(); 
            }
        }

        private void setAge() {
            if(!int.TryParse(Console.ReadLine(), out this.age) || this.age < 0 || this.age > 200 ) {
                Console.Write("\n \t Por favor, insira uma idade válida: ");
                setAge();
            }
        }

        private void verifyAge() {

            switch (this.age)
                {
                    case int n when (n < 18):
                        Console.Write($"menor de idade. \n");
                        break;
                    case int n when (n >= 18 && n < 65):
                        Console.Write($"maior de idade. \n");
                        break;
                    case int n when (n >= 65):
                        Console.Write($"idoso. \n");
                        break;
                    default:
                        Console.WriteLine("Idade inválida");
                        break;
                }
        }

        public override void execute()
        {
            Console.Clear();
            Console.WriteLine("\t Executando exercicio 3...");
            Console.Write("\n \t \"Faça um programa que leia o nome e a idade do paciente ");
            Console.Write("\n \t e como resultado mostre o nome do paciente. ");
            Console.WriteLine("\n \t E a mensagem se é menor ou maior de idade e se é idoso.\" ");

            Console.Write("\n \t Insira o nome do paciente: ");

            this.setName();

            Console.Write("\n \t Insira a idade do paciente: ");
            this.setAge();

            Console.Write($"\n \t O paciente {this.name} tem {this.age} anos e é ");
            
            this.verifyAge();

        }
    }
}

/*
Faça um programa que leia o nome e a idade do paciente e como resultado mostre o nome do paciente. E a mensagem se é menor ou maior de idade e se é idoso.
*/ 