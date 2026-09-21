using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Francisco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10 - Francisco tem 1,50m e cresce 2 centímetros por ano, enquanto Sara tem 1,10m e cresce 3 centímetros por ano. 
             * Faça um algoritmo que calcule e 
             * imprima na tela em quantos anos serão necessários para que Francisco seja maior que Sara.*/

            double francisco = 1.50;
            double sara = 1.10;
            int anos = 0;

            // Cálculo do crescimento
            while (sara <= francisco)
            {
                francisco = francisco + 0.02;
                sara = sara + 0.03;
                anos++;
            }

            // Exibição do resultado
            Console.WriteLine("Serão necessários " + anos + " anos.");
            Console.WriteLine("Francisco terá " + francisco.ToString("F2") + " m.");
            Console.WriteLine("Sara terá " + sara.ToString("F2") + " m.");
        }
    }
}
