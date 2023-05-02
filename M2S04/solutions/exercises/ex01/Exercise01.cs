using Spectre.Console;
using Exercise01;

namespace Exercise;
class Exercise01 : ExerciseBase
{
    public int DefinirIdade() {
        return AnsiConsole.Prompt(
            new TextPrompt<int>("Qual é a sua [red]idade[/]?")
                .ValidationErrorMessage("[red]Insira uma idade válida[/]")
                .Validate(age =>
                {
                    return age switch
                    {
                        <= 0 => ValidationResult.Error("[red]Você precisa ter pelo menos 1 ano de idade.[/]"),
                        >= 123 => ValidationResult.Error("[red]Você precisa ser mais novo do que a pessoa mais velha viva.[/]"),
                        _ => ValidationResult.Success(),
                    };
                }));
    }

    public override void execute()
    {
        var name = AnsiConsole.Ask<string>("Qual é o [green]nome[/] da pessoa? ");
        int idade = DefinirIdade();
        var endereço = AnsiConsole.Ask<string>("Qual é o [blue]endereço[/]?");

        var pessoa = new Pessoa(name, idade, endereço);
        
        pessoa.Saudacao();
    }
}

/*

Modificadores de acesso: default, public, protected, private, static e final:

Crie uma classe chamada "Pessoa" com os seguintes atributos:

Nome (private)

Idade (protected)

Endereço (public)

Crie também um método público chamado "saudacao" que imprime no console a seguinte mensagem: "Olá, meu nome é {nome da pessoa} e eu tenho {idade} anos".

Passo a passo:

Crie uma classe chamada "Pessoa".

Dentro da classe "Pessoa", declare os atributos "nome", "idade" e "endereco" com os modificadores de acesso "private", "protected" e "public", respectivamente.

Crie um construtor para a classe "Pessoa" que receba como parâmetros os valores para os atributos "nome", "idade" e "endereco" e atribua esses valores aos respectivos atributos.

Crie um método público chamado "saudacao" que imprime no console a mensagem "Olá, meu nome é {nome da pessoa} e eu tenho {idade} anos".

Para testar a classe, crie um objeto "pessoa1" do tipo "Pessoa" e atribua valores para os atributos "nome", "idade" e "endereco". Em seguida, chame o método "saudacao" do objeto "pessoa1".

*/