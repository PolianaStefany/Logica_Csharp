using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ValorAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7-  Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.*/
            int A;
            int B;
            int auxiliar;

         
            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

        
            Console.WriteLine("\nAntes da troca:");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

           
            auxiliar = A;
            A = B;
            B = auxiliar;

            
            Console.WriteLine("\nDepois da troca:");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
        }
    }
}
    

