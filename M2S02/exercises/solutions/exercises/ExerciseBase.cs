namespace ConsoleExercise
{
    class ExerciseBase
    {
        public string name { get; set; }
        public string description { get; set; }

        public virtual void execute()
        {
            Console.WriteLine("Executando exercício base...");
        }
    }

}