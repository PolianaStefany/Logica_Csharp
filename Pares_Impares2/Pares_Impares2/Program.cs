using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pares_Impares2
{
    internal class Program
    {
       // Crie um programa que armazene 20 números e separe - os em dois arrays: um com números pares e outro com números ímpares.
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            int[] pares = new int[20];
            int[] impares = new int[20];
            int p= 0, i = 0;

            for   (int j = 0; j < 20;  j++) 
            {

                Console.Write("Digite o numero {j + 1}:");
                numeros[j] = int.Parse(Console.ReadLine());

                if (numeros[j] % 2 == 0) pares[p++] = numeros[j];
                else impares[i++] = numeros[j];

                }

            Console.WriteLine("\nPares:");
            for(int j = 0; j < p; j++) Console.WriteLine(pares[j]+" ");

            Console.WriteLine("\nÍmpares: ");
            for (int j = 0; j < i; j++) Console.WriteLine(impares[j] + " ");
        }
    }
}
