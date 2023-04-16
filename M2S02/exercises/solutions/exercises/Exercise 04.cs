namespace ConsoleExercise
{
    
    class Exercise04 : ExerciseBase
    {
        private String marca;
        private String modelo;

        private float km;

        private void setMarca() {
            this.marca = Console.ReadLine();

            if (this.marca.Length < 1) {
                Console.Write("\n \t Por favor, digite a marca correta: ");
                setMarca();
            }
        }

        private void setModelo() {
            this.modelo = Console.ReadLine();

            if (this.modelo.Length < 1) {
                Console.Write("\n \t Por favor, digite a modelo correta: ");
                setModelo();
            }
        }

        private void setKm() {
            if(!float.TryParse(Console.ReadLine(), out this.km)) {
                Console.Write("\n \t Por favor, digite um número válido: ");
                setKm();
            }
        }

        private void verificaKm() {
            if (this.km > 10000) {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("precisa de revisão. \n");
            } else {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("não precisa de revisão. \n");
            }

            Console.ReadKey();
        }

        public override void execute()
        {
            Console.Clear();
            Console.WriteLine("\n \t Executando exercicio 4...");
            Console.Write("\n \t \"Faça um programa que leia a Marca, Modelo e km rodados ");
            Console.Write("\n \t e mostre as informações do carro e se a KM for acima 10 mil, ");
            Console.WriteLine("\n \t apresentar a mensagem que precisa ser feito uma revisão.\" ");

            Console.Write("\n \t Insira a marca do carro: ");

            this.setMarca();

            Console.Write("\n \t Insira o modelo do carro: ");

            this.setModelo();

            Console.Write("\n \t Insira a quilometragem do carro: ");

            this.setKm();

            Console.Write($"\n \t O carro da marca {this.marca}, modelo {this.modelo} tem {this.km} km rodados e ");
            
            this.verificaKm();

            Console.ResetColor();

        }
    }
}

/*
Faça um programa que leia a Marca, Modelo e  km rodados e mostre as informações do 
carro e se a KM for acima 10 mil, apresentar a mensagem 
que precisa ser feito uma revisão.
*/