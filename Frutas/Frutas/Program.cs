using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frutas
{
    internal class Program
    {
        //Implemente um sistema que armazene as quantidades de 5 tipos de frutas em 3 cesta e calcule o total de frutas de cada tipo
        static void Main(string[] args)
        {
            // Vetor com os nomes das frutas para facilitar a exibição
            string[] tipos  = { "Maçã", "Banana", "Laranja", "Uva", "Morango" };

            int[,] frutas = new int[5, 3];
           ;
            for (int i = 0; i < 5; i++) {
            

            Console.WriteLine($"\n {tipos[i]}:");

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Cesta{j + 1}:");
                    frutas[i, j] = int.Parse(Console.ReadLine());
                }

              
                }

                
                Console.WriteLine("\nTotal de cada fruta:");
            for (int i = 0; i < 5; i++)
            {
                int total = frutas[i, 0] + frutas[i, 1] + frutas[i, 2];
                Console.WriteLine($"{tipos[i]}: {total}");
            }
            }
        }
    }

    




        
    
