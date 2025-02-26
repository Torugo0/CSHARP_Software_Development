using System; // Import de classes como console e datetime

class Program // Classe é um modelo que define um tipo de objeto. Ela contem atributos (Dados) e métodos (Comportamentos)
{
    static void Main()
    {
        
        Console.Write("Digite sua data de nascimento: ");
        DateTime dtNasc = DateTime.Parse(Console.ReadLine());
        var diff = DateTime.Now - dtNasc;
        int idade = (int)Math.Truncate((diff.TotalDays / 365));
        Console.WriteLine($"Você tem {idade} anos !");
    }
}

/*
Console.Write() = Retorna a string ou valor informado em uma linha sem pular para a proxima. Então se eu colocar dois console.write, as duas vão ficar na mesma linha. 
    EX: Console.Write("Hello ")
        Console.Write("World")

Console.WriteLine() = Diferente do Write(), ele exibe o valor em linha única. Pulando para a próxima linha caso tenha outro Write() ou WriteLine()

✅ Se você quer exibir algo e continuar na mesma linha, use Write().
✅ Se quer exibir e já pular para a próxima linha, use WriteLine().


Console.Read() = Lê apeans um caractere da entrada do usuário, e retorna um int, o código ASCII. Um ponto a ficar atento é que ele não lê palavras inteiras.
                 OBS: Sempre vai ser necessario converter esta entrada para uma string ou outro valor caso não seja int. O valor digitador e lido em Read() sempre vai retornar um INT.
    EX: Console.Write("Digite uma letra: ");
        int letra = Console.Read();
        Console.WriteLine($"Você digitou: {(char)letra}");

Console.ReadLine() = Lê uma linha inteira digitada pelo usuário e retorna uma string do valor, sendo necessârio fazer a conversão dele caso não deseje uma string.
    EX: Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}!");

Console.ReadKey() = Lê apenas um caractere pressionado pelo usuário. Não precisa digitar enter para confirmar.

    EX: Console.Write("Pressione qualquer tecla para continuar...");
         // Console.ReadKey();
        Console.ReadKey(true); // Oculta a tecla digitada


 
 
 */