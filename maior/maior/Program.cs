using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, menor, maior;
            Console.WriteLine("Escolha um numero: ");
            num1 = int.Parse(Console.ReadLine());
            maior = num1 + 1;
            menor = num1 - 1;
            Console.WriteLine("O antessesor é "+ menor);
            Console.WriteLine(",O sucessor é "+ maior);
        }
    }
}
