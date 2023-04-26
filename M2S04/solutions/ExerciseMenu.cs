using Spectre.Console;

namespace Exercise
{
    class ExerciseMenu
    {
        public List<ExerciseBase> Exercises = new List<ExerciseBase>();

        public ExerciseMenu() {
            Exercises.Add(new Exercise01() { name = "M2S04 ~ Ex 01", description = "Modificadores de Acesso: Saudação Pessoa" });
            Exercises.Add(new Exercise02() { name = "M2S04 ~ Ex 02", description = "Encapsulamento" });
            Exercises.Add(new Exercise03() { name = "M2S04 ~ Ex 03", description = "Banco: modificadores de acesso, construtores e métodos" });
            Exercises.Add(new Exercise04() { name = "M2S04 ~ Ex 04", description = "Encapsulamento ContaBancaria" });
            Exercises.Add(new Exercise05() { name = "M2S04 ~ Ex 05", description = "Encapsulamento Classe Pessoa" });
            Exercises.Add(new Exercise06() { name = "M2S04 ~ Ex 06", description = "Encapsulamento Classe Retângulo" });
            Exercises.Add(new Exercise07() { name = "M2S04 ~ Ex 07", description = "Constante Valor Máximo Conta" });
            Exercises.Add(new Exercise08() { name = "M2S04 ~ Ex 08", description = "Classe Abstrata e Herança" });
            Exercises.Add(new Exercise09() { name = "M2S04 ~ Ex 09", description = "Calculadora: Classe Estática" });
            Exercises.Add(new Exercise10() { name = "M2S04 ~ Ex 10", description = "Criação de Classe Conta Bancária com Transações" });
        }

        public void runExercise(int choice) {
            Exercises[choice].execute();
            AfterExerciseRun();
        }

        public void AfterExerciseRun() {
            var selectionList = new List<String>();
            selectionList.Add("Retornar ao Menu");
            selectionList.Add("Repetir exercício");
            selectionList.Add("Sair");
            
            var menuSelection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Selecione uma opção: ")
                    .MoreChoicesText("[grey]Use as setas para selecionar a opção[/]")
                    .AddChoices(selectionList.ToArray()));
            
            var selected = Array.IndexOf(selectionList.ToArray(), menuSelection);
        }

        
    }
}