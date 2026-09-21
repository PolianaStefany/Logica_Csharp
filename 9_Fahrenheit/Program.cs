using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9- Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.
Fórmula: C = (5 * ( F-32) / 9)*/

            double fahrenheit;
            double celsius;

           
            Console.Write("Digite a temperatura em Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            // Cálculo da temperatura em Celsius
            celsius = (5 * (fahrenheit - 32)) / 9;

            // Exibição das temperaturas
            Console.WriteLine("\nTemperatura em Fahrenheit: " + fahrenheit + " °F");
            Console.WriteLine("Temperatura em Celsius: " + celsius.ToString("F2") + " °C");
        }
    }
}
