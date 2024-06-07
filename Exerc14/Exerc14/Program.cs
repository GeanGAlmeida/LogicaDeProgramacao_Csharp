using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double novoNum;
            // Escreva um programa que leia um número e informe se ele é positivo ou negativo.
            // Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado.

            Console.Write("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                novoNum = Math.Sqrt(num);
                Console.WriteLine(novoNum);
            }
            else
            {
                novoNum = Math.Pow(num,2);
                Console.WriteLine(novoNum);
            }
            Console.ReadKey(); 
        }
    }
}
