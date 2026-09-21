using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_Adivinhação
{
    internal class Program
    {
        /* Simular o jogo de adivinhação: o jogador 1 escolhe um numero entre 1 e 10; o jogador 2 insere numeros na tentativa de acerta o número entre 1 e 10;
         * o jogador 2 insere números na tentativa de acerta o número escolhido pelo jogador 1. Quando ele acerta, o algoritmo deve informar que ele acertou 
         * o número x (escolhido pelo jogador 1) em x tentativas (quantidade de tentativas do jogador 2).*/
        static void Main(string[] args)
        {
            int numeroEscolhido = 0;
            int palpite = 0;
            int quantidadeTentativas = 0;

            // Fase do Jogador 1: Escolha do número
            while (true)
            {
                Console.Write("Jogador 1, escolha um número entre 1 e 10: ");
                if (int.TryParse(Console.ReadLine(), out numeroEscolhido) && numeroEscolhido >= 1 && numeroEscolhido <= 10)
                {
                    break;
                }
                Console.WriteLine("Número inválido! O número deve estar entre 1 e 10.");
            }

            // Limpa o console para que o Jogador 2 não veja a resposta
            Console.Clear();
            Console.WriteLine("Jogador 2, o jogo começou! Tente adivinhar o número.");

            // Fase do Jogador 2: Tentativas de adivinhação
            do
            {
                Console.Write("Insira o seu palpite: ");
                if (int.TryParse(Console.ReadLine(), out palpite))
                {
                    quantidadeTentativas++;

                    if (palpite == numeroEscolhido)
                    {
                        Console.WriteLine($"\nVocê acertou o número {numeroEscolhido} em {quantidadeTentativas} tentativas!");
                    }
                    else
                    {
                        Console.WriteLine("Incorreto. Tente novamente!");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número inteiro válido.");
                }

            } while (palpite != numeroEscolhido);
        }
    }
}
    

