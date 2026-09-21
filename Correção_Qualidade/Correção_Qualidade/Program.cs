using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correção_Qualidade
{
    internal class Program
    {
        /* Simular o jogo de adivinhação: o jogador 1 escolhe um numero entre 1 e 10; o jogador 2 insere numeros na tentativa de acerta o número entre 1 e 10;
         * o jogador 2 insere números na tentativa de acerta o número escolhido pelo jogador 1. Quando ele acerta, o algoritmo deve informar que ele acertou 
         * o número x (escolhido pelo jogador 1) em x tentativas (quantidade de tentativas do jogador 2).*/
        static void Main(string[] args)
        {
            int num1, num2, contador, tentativa = 0;
            Console.WriteLine("Digite o numero para ser adivinhado: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Clear();

            for(contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine("\nDigite a " + contador + "° tentativa: ");
                num2 = int.Parse(Console.ReadLine());
                if (num2 == num1)
                {
                    Console.WriteLine("Voce acertou o número em: " + tentativa + "tentativas");
                    break;
                }
                else
                {
                    tentativa = contador + 1;
                    Console.WriteLine("\ntente novamente");
                }
                    }
                }

            }
                
        }
    

