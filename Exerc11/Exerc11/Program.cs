using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia um número e verifique se ele está no intervalo de 10 a 20 (inclusive). 

            Console.Write("Digite um numero entre 10 a 20: ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();

            if (num >= 10 && num <= 20)
            {
                Console.WriteLine(num +" esta no intervalo de 10 a 20");
            }
            else
            {
                Console.WriteLine("Este numero esta fora do intervalo de 10 a 20");
            }
            Console.ReadKey();
        }
    }
}
