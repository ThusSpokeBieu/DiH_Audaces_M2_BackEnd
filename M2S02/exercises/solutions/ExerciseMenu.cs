namespace ConsoleExercise
{
    class ExerciseMenu
    {
        private List<ExerciseBase> exercises = new List<ExerciseBase>();

        public ExerciseMenu()
        {
            exercises.Add(new Exercise1() { name = "[M2S02] Ex 1 ", description = "Soma de números" });
            exercises.Add(new Exercise2() { name = "[M2S02] Ex 2 ", description = "Par ou ímpar" });
            exercises.Add(new Exercise3() { name = "[M2S02] Ex 3 ", description = "Nome e Idade" });
            exercises.Add(new Exercise4() { name = "[M2S02] Ex 4 ", description = "Informação de Veículos" });
            exercises.Add(new Exercise5() { name = "[M2S02] Ex 5 ", description = "Ordenando Números" });
            exercises.Add(new Exercise6() { name = "[M2S02] Ex 6 ", description = "Separando palavras" });
            exercises.Add(new Exercise7() { name = "[M2S02] Ex 7 ", description = "Números pares" });
            exercises.Add(new Exercise8() { name = "[M2S02] Ex 8 ", description = "O maior número da lista" });
            exercises.Add(new Exercise9() { name = "[M2S02] Ex 9 ", description = "Média aritmética" });
            exercises.Add(new Exercise10() { name = "[M2S02] Ex 10 ", description = "Calculadora" });
        }

        public void runExercise(int choice) {
            exercises[choice - 1].execute();
            afterExerciseOption(choice);
        }

        public void afterExerciseOption(int choice) {
            Console.WriteLine("\n \t Escolha uma opção:");
            Console.WriteLine("\t 1 - Retornar ao menu de exercícios.");
            Console.WriteLine("\t 2 - Repetir o exercício.");
            Console.WriteLine("\t 3 - Sair.");

            Console.Write("\n\t Insira uma opção: ");
            
            if (!int.TryParse(Console.ReadLine(), out int option)) {
                Console.WriteLine("\n \t Opção inválida! Por favor, escolha uma correta.");
                Console.ReadKey();
                Console.Clear();
                afterExerciseOption(choice);
            }

            switch (option)
            {
                case 1:
                    ShowMenu();
                    break;
                case 2:
                    runExercise(choice);
                    break;
                case 3:
                    Console.WriteLine("\n \t Encerrando o programa... Até mais!");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\n \t Opção inválida! Por favor, escolha uma correta.");
                    Console.ReadKey();
                    Console.Clear();
                    afterExerciseOption(choice);
                    break;
                }
        }


        public void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
       ___  _ __ __        ___________ _____   ___  ___ 
      / _ \(_) // / ____  / ___/ __/ // / _ | / _ \/ _ \
     / // / / _  / /___/ / /___\ \/ _  / __ |/ , _/ ___/
    /____/_/_//_/        \___/___/_//_/_/ |_/_/|_/_/"
            );

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
         _______   __ ___________  _____ _____ _____ _____ _____ 
        |  ___\ \ / /|  ___| ___ \/  __ \_   _/  ___|  ___/  ___|
        | |__  \ V / | |__ | |_/ /| /  \/ | | \ `--.| |__ \ `--. 
        |  __| /   \ |  __||    / | |     | |  `--. \  __| `--. \
        | |___/ /^\ \| |___| |\ \ | \__/\_| |_/\__/ / |___/\__/ /
        \____/\/   \/\____/\_| \_| \____/\___/\____/\____/\____/
            "    
            );

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\t MENU DE EXERCICIOS: \n");
            for (int i = 0; i < exercises.Count; i++)
            {
                Console.WriteLine($"\t {i + 1}. {exercises[i].name} - {exercises[i].description}");
            }

            Console.Write("\n \t Insira o número do exercício que quer executar: ");
            
            if (int.TryParse(Console.ReadLine(), out int choice) 
                && choice > 0 && choice <= exercises.Count) {
                runExercise(choice);
            }
            else
            {
                Console.WriteLine("\t Por favor, insira um número correto.");
                Console.ReadKey();
                ShowMenu();
            }
        }
    }
}