using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia um número e verifique se ele é maior que 100. Se não for, informe o dobro desse número.
            Console.Write("Coloque o numero maior que numero 100: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 100)
            {
                int dobro = num * 2;
                Console.WriteLine("O dobro do numero " + num +" é " + dobro);
            }
            else
            {
                Console.WriteLine("Valor maior que 100");
            }
            Console.ReadKey();
        }
    }
}
