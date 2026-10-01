using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pares_Impares
{
    internal class Program
    {
        //"Crie um programa que armazene 20 números e separe-os em dois arrays: um com números pares e outro com números ímpares.

        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            int contadorPares = 0;
            int contadorImpares = 0;

            // Leitura dos 20 números
            Console.WriteLine("Digite 20 números inteiros:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }
            }

            // Criação dos arrays com os tamanhos exatos
            int[] pares = new int[contadorPares];
            int[] impares = new int[contadorImpares];

            // Índices de controle para preencher os novos arrays
            int idxPar = 0;
            int idxImpar = 0;

            // Separação dos números
            for (int i = 0; i < 20; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares[idxPar] = numeros[i];
                    idxPar++;
                }
                else
                {
                    impares[idxImpar] = numeros[i];
                    idxImpar++;
                }
            }

            // Exibição dos resultados
            Console.WriteLine("\n--- Resultados ---");

            Console.WriteLine($"\nNúmeros Pares ({pares.Length} encontrados):");
            Console.WriteLine(pares.Length > 0 ? string.Join(", ") : "Nenhum número par.");

            Console.WriteLine($"\nNúmeros Ímpares ({impares.Length} encontrados):");
            Console.WriteLine(impares.Length > 0 ? string.Join(", ") : "Nenhum número ímpar.");
        }
    }
}
