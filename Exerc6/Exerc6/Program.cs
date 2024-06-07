using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia um ano e verifique se ele é bissexto.
             * Um ano é bissexto se for divisível por 4, mas não por 100, exceto se for divisível por 400*/

            Console.WriteLine("Informe um ano para verificar se é um ano bissexto");
            int ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                Console.WriteLine(ano+" é um ano bissexto");
            }
            else
            {
                Console.WriteLine(ano + " não é um ano bissexto");
            }

            Console.ReadKey();
        }
    }
}
