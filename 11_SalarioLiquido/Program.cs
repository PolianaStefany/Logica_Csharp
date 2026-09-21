using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_SalarioLiquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11- Faça um algoritmo que efetue o cálculo do salário líquido de um professor. 
             * As informações fornecidas serão: valor da hora aula, número de aulas lecionadas no mês e percentual de desconto do INSS. Imprima na tela o salário líquido final.*/
            double valorHora;
            double numeroAulas;
            double percentualINSS;
            double salarioBruto;
            double descontoINSS;
            double salarioLiquido;

            Console.Write("Digite o valor da hora aula: R$ ");
            valorHora = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de aulas no mês: ");
            numeroAulas = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de desconto do INSS: ");
            percentualINSS = double.Parse(Console.ReadLine());

            // Cálculo do salário bruto
            salarioBruto = valorHora * numeroAulas;

            // Cálculo do desconto
            descontoINSS = salarioBruto * percentualINSS / 100;

            // Cálculo do salário líquido
            salarioLiquido = salarioBruto - descontoINSS;

            // Resultado
            Console.WriteLine("Salário líquido: R$ " + salarioLiquido.ToString("F2"));
        }
    }
    }

