using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AnoQueNasceu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  8 - Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e dias essa pessoa ja viveu.Leve em
  consideração o ano com 365 dias e o mês com 30 dias.
  (Ex: 5 anos, 2 meses e 15 dias de vida)*/

            int anoNascimento;
            int anoAtual;
            int idadeAnos;
            int idadeMeses;
            int idadeDias;
            int totalDias;

            
            Console.Write("Digite o ano em que você nasceu: ");
            anoNascimento = int.Parse(Console.ReadLine());

           
            anoAtual = DateTime.Now.Year;

            // Calcula a quantidade total de dias vividos
            totalDias = (anoAtual - anoNascimento) * 365;

            // Converte os dias para anos, meses e dias
            idadeAnos = totalDias / 365;
            totalDias = totalDias % 365;

            idadeMeses = totalDias / 30;
            idadeDias = totalDias % 30;

            // Exibe o resultado
            Console.WriteLine("\nVocê já viveu aproximadamente:");
            Console.WriteLine(idadeAnos + " anos, " + idadeMeses + " meses e " + idadeDias + " dias.");

        }
    }
}
