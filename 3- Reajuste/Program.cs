using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());

            double reajuste = valor * 1.05;

            Console.WriteLine("Valor com reajuste de 5%: " + reajuste);
        }
    }


}
    

