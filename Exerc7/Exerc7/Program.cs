using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia a idade de uma pessoa e informe se ela é uma criança (0-12 anos),
             * adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais). */

            Console.WriteLine("Informe sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 0)
            {
                Console.WriteLine("Idade invalida");
            }
            else if (idade >= 0 && idade <= 12)
            {
                Console.WriteLine("É uma criança");
            }
            else if (idade >= 13 && idade <= 17) 
            {
                Console.WriteLine("É um Adolescente");
            }
            else if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine("É um Adulto");
            }
            else
            {
                Console.WriteLine("É um idoso");
            }

            Console.ReadKey();
        }
    }
}
