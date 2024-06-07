using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa que leia três lados de um triângulo e verifique se eles formam um triângulo válido." +
                " Para isso, a soma de dois lados deve ser sempre maior que o terceiro lado");

            Console.WriteLine("Digite o valor do primeiro lado do triângulo");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo lado do triângulo");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro lado do triângulo");
            int valor3 = int.Parse(Console.ReadLine());

            if (valor1 + valor2 > valor3 && valor2 + valor3 > valor1 && valor3 + valor1 > valor2)
            {
                Console.WriteLine("É um triângulo válido");
            }
            else
            {
                Console.WriteLine("Não é um triângulo válido");
            }

            Console.ReadKey();
        }
    }
}
