using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura__da_semana
{
    internal class Program
    {
        //Crie um algoritmo que armazene as temperaturas diárias de uma cidade durante uma semana e informe o dia mais quente e o mais frio
        static void Main(string[] args)
        {
            double[] temperaturas = new double[7];
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Digite a temperatura do dia {i + 1}: ");
                temperaturas[i] = double.Parse(Console.ReadLine());
            }

            double maior = temperaturas[0]; 
            double menor = temperaturas[0]; int diaMaisQuente = 1; int diaMaisFrio = 1;

            for (int i = 1; i < 7; i++)
            {
                if (temperaturas[i] > maior)
                { maior = temperaturas[i]; diaMaisQuente = i + 1; }
                if (temperaturas[i] < menor) { menor = temperaturas[i]; diaMaisFrio = i + 1; }
            }
            Console.WriteLine($"Dia mais quente: Dia {diaMaisQuente}, {maior}°C");
            Console.WriteLine($"Dia mais frio: Dia {diaMaisFrio}, {menor}°C");
        }
    }
}