using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioMinimo = 1518.00;

            Console.Write("Digite o salário do usuário: ");
            double salario = double.Parse(Console.ReadLine());

            double quantidade = salario / salarioMinimo;

            Console.WriteLine("O usuário ganha aproximadamente " + quantidade + " salários mínimos.");
        }
    }
}
    
