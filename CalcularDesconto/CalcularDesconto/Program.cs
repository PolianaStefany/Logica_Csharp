using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDesconto
{

    /*
     * 5. Calcular desconto
     Um produto com preço acima de 100 reais tem um desconto de 10%. Caso contrário, o desconto e de 5%.
    Dado o preço, calcule o valor do desconto.
    Entrada: 120
    Saída espera: 12 reais de desconto 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            double preco;
            double desconto;
            Console.Write("Digite o valor: ");
            preco = double.Parse(Console.ReadLine());

            if (preco > 100)
            {
                desconto = preco * 0.10;
                Console.WriteLine(desconto + "reais de desconto");
            }
            else

            {
                desconto = preco * 0.05;
                Console.WriteLine(desconto + "reais desconto");
                {
                   
                }



            }
        }
    }
}
