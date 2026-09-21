using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /* Construa um programa que permita fazer o levantamento do estoque de vinhos de uma adega, tendo como dados de entrada
        tipos de vinho, sendo: "t" ´para tinto e "b" para branco. Como a quantidade de vinhos é desconhecida, utilize a letra "f"
        para finalizar.Após finalizar o programa deve mostrar a quantidade de cada vinho na adega. */

        static void Main(string[] args)
        {



            

                int QuantidadeTinto = 0, QuantidadeBranco = 0, contador;
                String vinhos;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(@"
░█████╗░██████╗░███████╗░██████╗░░█████╗░  ██████╗░███████╗  ██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░░██████╗
██╔══██╗██╔══██╗██╔════╝██╔════╝░██╔══██╗  ██╔══██╗██╔════╝  ██║░░░██║██║████╗░██║██║░░██║██╔══██╗██╔════╝
███████║██║░░██║█████╗░░██║░░██╗░███████║  ██║░░██║█████╗░░  ╚██╗░██╔╝██║██╔██╗██║███████║██║░░██║╚█████╗░
██╔══██║██║░░██║██╔══╝░░██║░░╚██╗██╔══██║  ██║░░██║██╔══╝░░  ░╚████╔╝░██║██║╚████║██╔══██║██║░░██║░╚═══██╗
██║░░██║██████╔╝███████╗╚██████╔╝██║░░██║  ██████╔╝███████╗  ░░╚██╔╝░░██║██║░╚███║██║░░██║╚█████╔╝██████╔╝
╚═╝░░╚═╝╚═════╝░╚══════╝░╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═════╝░");
            Console.ResetColor();    
            for (contador = 1; contador > 0; contador++)
                {


                    Console.Write("Digite o tipo do vinho ou Digite ('f' para finalizar o programa \n Digite 't' para vinho tinto e 'b' para vinho branco): ");
                    vinhos = Console.ReadLine();

                    if (vinhos == "b")
                    {
                        QuantidadeBranco++;

                    }
                    if (vinhos == "t")
                    {
                        QuantidadeTinto++;
                    }
                    Console.Clear();
                    if (vinhos == "f")
                    {
                        Console.WriteLine("O total de vinhos brancos em estoque são> " + QuantidadeBranco + "\ne o de vinhos tintos são: " + QuantidadeTinto);
                    }
                }
            }
        }
    }



