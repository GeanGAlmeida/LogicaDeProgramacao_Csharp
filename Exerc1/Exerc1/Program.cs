using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificação se o é impar ou par");
            Console.WriteLine("Escreva um programa que leia um número inteiro e informe se ele é par ou ímpar");
            int num = int.Parse(Console.ReadLine());
            VerificaNumero(num);
           
        }
        static void VerificaNumero(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("O numero " + num + " é par");
            }
            else
            {
                Console.WriteLine("O numero " + num + " é impar");
            }
            Console.ReadKey();
        }
    }
}
