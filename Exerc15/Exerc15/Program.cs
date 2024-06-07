using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia o peso e a altura de uma pessoa, calcule o IMC e informe a categoria.

            Console.Write("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Informe sua peso: ");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine(imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc >= 30 && imc < 34.9)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (imc >= 35 && imc < 39.9)
            {
                Console.WriteLine("Obesidade Grau II");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Obesidade Grau III");
            }

            Console.ReadKey();
        }
    }
}
