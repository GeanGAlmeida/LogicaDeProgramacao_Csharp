using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa que leia dois números inteiros e informe qual deles é o maior");
            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O numero " + num1 + " é maior que " + num2);
            }
            else
            {
                Console.WriteLine("O numero " + num2 + " é maior que " + num1);
            }

            Console.ReadKey();
        }
    }
}
