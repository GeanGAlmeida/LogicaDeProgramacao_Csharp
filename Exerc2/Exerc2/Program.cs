using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero");
            Console.WriteLine("Digite um numero inteiro");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Esse numero é positivo");
            }
            else if(num == 0)
            {
                Console.WriteLine("Esse numero é "+num);
            }
            else
            {
                Console.WriteLine("Esse numero é negativo");
            }

            Console.ReadKey();
        }
    }
}
