using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Verdadeiro_Falso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4-	Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.*/

            
            bool valor1;
            bool valor2;

       
            Console.Write("Digite o primeiro valor (true/false): ");
            valor1 = bool.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor (true/false): ");
            valor2 = bool.Parse(Console.ReadLine());

            
            if (valor1 == true && valor2 == true)
            {
                Console.WriteLine("Ambos são VERDADEIROS.");
            }
            else if (valor1 == false && valor2 == false)
            {
                Console.WriteLine("Ambos são FALSOS.");
            }
            else
            {
                Console.WriteLine("Um é VERDADEIRO e o outro é FALSO.");
            }
        }
    }
}
    

    

