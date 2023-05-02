using Spectre.Console;

namespace Exercise01;

public class Pessoa
{
    public String Nome;
    protected int Idade;
    private String Endereço;

  public Pessoa(string nome, 
                int idade, 
                string endereço)
  {
    Nome = nome;
    Idade = idade;
    Endereço = endereço;
  }

  public void Saudacao() 
  {
    AnsiConsole.MarkupInterpolated($"Olá, meu nome é [green]{this.Nome}[/], tenho [red]{this.Idade}[/] e moro no endereço: [blue]{this.Endereço}[/]");
  }
}
