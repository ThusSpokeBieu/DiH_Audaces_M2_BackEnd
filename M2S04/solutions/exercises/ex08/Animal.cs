namespace Exercise08;

public abstract class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public abstract void EmitirSom();
}
