using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_Bissexto
{

    /* 
     * 6. Ano bissexto
     Determine se um ano é bissexto. Um ano é bissexto se for divosível por 4, mas não por 100, a nao ser que seja divisível por 400
     Entrada: 2024
     Saída esperada: Ano bissexto
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int ano;
            Console.Write("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine("Ano bissexto");
            }
            else if (ano % 400 == 0)
            {
                Console.WriteLine("Ano bissexto");
            }
            else
            {
                Console.WriteLine("Não bissexto");

            }





        }

    }
}