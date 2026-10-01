using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra_Cliente
{
    internal class Program
    {
        // Desenvolva um programa que armazene o histórico de compras de 10 clientes e mostre o total gasto por cada cliente

        static void Main(string[] args)
        {
            double[,] compras = new double[10, 5];

            // Cadastro dos valores das compras
            for (int i = 0; i < 10; i++)
            {
                double total = 0;
                Console.WriteLine($"Cliente {i + 1}");

                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Digite o valor da compra {j + 1}: R$ ");
                    compras[i, j] = double.Parse(Console.ReadLine());
                    total += compras[i, j];
                }





                Console.WriteLine("===== TOTAL GASTO POR CLIENTE =====");

              

                Console.WriteLine($"total gasto pelo Cliente {i+ 1}: R$ {total:0,00}");
            }
        }

    }

}    