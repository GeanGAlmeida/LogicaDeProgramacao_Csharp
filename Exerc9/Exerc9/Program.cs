using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia o código de um produto e informe a sua categoria
            Console.WriteLine("Informe o codigo do produto pra saber sua categoria");
            int cod = int.Parse(Console.ReadLine());

            if (cod >= 1 && cod <= 10)
            {
                Console.WriteLine("Essa categoria é de Alimentos não-perecíveis");
            }
            else if(cod >= 11 && cod <= 20)
            {
                Console.WriteLine("Essa categoria é de Alimentos Perecíveis");
            }
            else if (cod >= 21 && cod <= 30)
            {
                Console.WriteLine("Essa categoria é de Vestuário");
            }
            else if (cod >= 31 && cod <= 40)
            {
                Console.WriteLine("Essa categoria é de Eletrônicoss");
            }
            else
            {
                Console.WriteLine("Código inválido");
            }

            Console.ReadKey();
        }
    }
}
