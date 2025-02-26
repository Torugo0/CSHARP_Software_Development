using System.Globalization;

class Program
{
    static void Main()
    {
        // Exemplo de conversão implicita e explicita respectivamente:
        int inteiro = 10;
        double flutuante = inteiro;

        double flutuante2 = 9.7;
        int inteiro2 = (int)flutuante2; // Aqui é interessante prestar atenção pois ele arredonda e pode causar imprecisão.

        // Operador as 

        object obj1 = "Olá";
        string str1 = obj1 as string;
        if(str1 != null)
        {
            Console.WriteLine(str1);
        }

        // Operador is

        object obj = "Texto";
        if (obj is String str)
        {
            Console.WriteLine(str); // Conversão segura
        }

        // Convert (Ver no PDF e atualizar)


        /*
         Codigo do desafio JOKEMPO

        using System;

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
        Console.WriteLine("1 - Sim ou 0 - Não");
        if(Console.ReadKey().KeyChar == '1')
        {
            Console.WriteLine("Então vamos começar...");
            Console.WriteLine("Escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋ ou 2 - Tesoura ✌");

            var opcao = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Para manter a formatação da saída

            var aleatorio = new Random();
            int escolhaMaquina = aleatorio.Next(0, 3); // O intervalo precisa ser (0,3) para incluir 0, 1 e 2.

            int opcaoInt = opcao - '0'; // Converte o char para int

            if (escolhaMaquina == opcaoInt) // empates
            {
                Console.WriteLine($"Minha escolha é {escolhaMaquina}, empatamos!");
            }else if(escolhaMaquina == 0 && opcaoInt == 2 || escolhaMaquina == 1 && opcaoInt == 0 || escolhaMaquina == 2 & opcaoInt == 1)
            {
                Console.WriteLine($"Minha escolha é {escolhaMaquina}, eu venci!");
            }
            else
            {
                Console.WriteLine($"Minha escolha é: {escolhaMaquina}, você venceu!");
            }
        }
        Console.WriteLine("👋 Tchau! Até a próxima");
         
         
         */

    }
}