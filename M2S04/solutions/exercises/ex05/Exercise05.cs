using Spectre.Console;
using Exercise05;

namespace Exercise
{
    class Exercise05 : ExerciseBase
    {
        public override void execute()
        {
            AnsiConsole.WriteLine("Rodando exercício 5");
            var Pessoa = new Pessoa();

            Pessoa.SetNome();
            Pessoa.SetIdade();

            AnsiConsole.WriteLine($"Eu sou {Pessoa.Nome} e tenho {Pessoa.Idade} anos.");
        }
    }

}