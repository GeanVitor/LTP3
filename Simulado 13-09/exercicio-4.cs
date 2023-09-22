using System;

namespace Simulado
{
    class AtividadeQuatro
    {
        static int jogadores;
        static string[] nomeJogador;
        static int[,] valores;
        static bool[] jogadoresAtivos;
        static int soma;
        static char letra;

        public static void Adedonha()
        {
            StartGame();
        }

        public static void StartGame()
        {
            Console.WriteLine("Digite a quantidade de jogadores (podem ser de 3-5 jogadores):");
            jogadores = Convert.ToInt32(Console.ReadLine());

            if (jogadores < 3 || jogadores > 5)
            {
                Console.WriteLine("Número de jogadores fora do intervalo permitido.");
                return;
            }

            nomeJogador = new string[jogadores];
            valores = new int[jogadores, 1];
            jogadoresAtivos = new bool[jogadores];

            for (int i = 0; i < jogadores; i++)
            {
                Console.WriteLine($"Informe o nome do jogador número {i + 1}º:");
                nomeJogador[i] = Console.ReadLine();
                jogadoresAtivos[i] = true;

                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine($"Informe o valor escolhido por {nomeJogador[i]}:");
                    valores[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            do
            {
                letra = SortAlfb(Soma());
                Console.WriteLine($"A letra correspondente ao valor somado é: {letra}");
                Respostas(letra);
            }
            while (ContagemJogadoresAtivos() > 1);

            int vencedor = Array.FindIndex(jogadoresAtivos, jogadorAtivo => jogadorAtivo);
            Console.WriteLine($"Parabéns, {nomeJogador[vencedor]}, você ganhou o jogo!!");
        }

        public static int Soma()
        {
            int soma = 0;
            for (int i = 0; i < jogadores; i++)
            {
                soma += valores[i, 0];
            }
            return soma;
        }

        public static char SortAlfb(int numero)
        {
            while (numero > 26)
            {
                numero -= 26;
            }
            char letra = (char)('A' + numero - 1);
            return letra;
        }

        public static void Respostas(char letraSorteada)
        {
            for (int i = 0; i < jogadores; i++)
            {
                if (jogadoresAtivos[i])
                {
                    Console.WriteLine($"Digite a palavra escolhida pelo jogador {nomeJogador[i]}:");
                    string palavraResp = Console.ReadLine();

                    if (palavraResp.Length == 0 || palavraResp[0] != letraSorteada)
                    {
                        Console.WriteLine($"O jogador {nomeJogador[i]} inseriu uma palavra inválida e está fora do jogo.");
                        jogadoresAtivos[i] = false;
                    }
                }
            }
        }

        public static int ContagemJogadoresAtivos()
        {
            int count = 0;
            for (int i = 0; i < jogadores; i++)
            {
                if (jogadoresAtivos[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}