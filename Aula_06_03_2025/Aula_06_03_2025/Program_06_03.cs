// Aula de Estrutura de controle de fluxo
// Codigo do desafio JOKEMPO

using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

List<string> nomesJogadores = new List<string>();  // Lista para armazenar os nomes dos jogadores
Dictionary<string, (int vitórias, int empates, int derrotas)> estatísticas = new Dictionary<string, (int, int, int)>();

// Metodos auxiliares

string validarNomeJogador()
{
    Console.Write("\nDigite seu nome: ");
    string nomeJogador = Console.ReadLine();

    return nomeJogador;
}

void validarResultado(int escolhaMaquina, int opcaoInt)
{
    if (escolhaMaquina == opcaoInt)
    {
        Console.WriteLine($"Minha escolha é {escolhaMaquina}, empatamos!\n");
    }
    else if (escolhaMaquina == 0 && opcaoInt == 2 || escolhaMaquina == 1 && opcaoInt == 0 || escolhaMaquina == 2 & opcaoInt == 1)
    {
        Console.WriteLine($"Minha escolha é {escolhaMaquina}, eu venci!\n");
    }
    else
    {
        Console.WriteLine($"Minha escolha é: {escolhaMaquina}, você venceu!\n");
    }
}

void jogoPrincipal()
{
    while (true)
    {
        Console.WriteLine("Escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋, 2 - Tesoura ✌ ou 3 - Sair");
        Console.WriteLine();

        var opcao = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Para manter a formatação da saída

        var aleatorio = new Random();
        int escolhaMaquina = aleatorio.Next(0, 3); // O intervalo precisa ser (0,3) para incluir 0, 1 e 2.

        int opcaoInt = opcao - '0'; // Converte o char para int

        if (opcaoInt == 3)
        {
            Console.WriteLine();
            Console.WriteLine("👋 Tchau! Até a próxima\n");
            break;
        }

        if (opcaoInt > 3 | opcaoInt < 0)
        {
            Console.WriteLine("Opção incorreta, por favor digitar apenas as opções informadas na tela");
            continue;
        }
        else
        {
            validarResultado(escolhaMaquina, opcaoInt);
        }
    }
}

void interfaceJokempo()
{
    while (true)
    {
        Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
        Console.WriteLine("1 - Sim ou 0 - Não");
        if (Console.ReadKey().KeyChar == '1')
        {

            string nomeJogador = validarNomeJogador();

            // Adiciona o nome do jogador à lista e inicializa as estatísticas
            if (!estatísticas.ContainsKey(nomeJogador))
            {
                estatísticas[nomeJogador] = (0, 0, 0); // vitórias, empates, derrotas
            }

            Console.WriteLine($"Bem-vindo(a) {nomeJogador}! Vamos começar...");

            jogoPrincipal();

        }
        else
        {
            Console.WriteLine("\n👋 Tchau! Até a próxima\n");
            break;
        }
    }
}

interfaceJokempo();