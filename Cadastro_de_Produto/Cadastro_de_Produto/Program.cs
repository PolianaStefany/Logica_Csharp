using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie um algorírimo para cadastro de produto; Código, Fabricante,  categoria, Preço
             estoque, valor total em estoque */
            int codigo, estoque;
            string fabricante, categoria;
            double preço, total;
            Console.WriteLine("Digite o código: ");
           codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o fabricante: ");
            fabricante = Console.ReadLine ();
            Console.WriteLine("Digite a categoria: ");
            categoria = Console.ReadLine ();
            Console.WriteLine("Digite o preço: ");
            preço = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o estoque: ");
            estoque = int.Parse(Console.ReadLine());
            total = preço * estoque;
            Console.WriteLine("O valor total em estoque é " + total);




        }
    }
}
