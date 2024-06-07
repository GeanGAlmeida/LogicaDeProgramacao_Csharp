using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double compraDesconto;
            //Escreva um programa que leia o valor de uma compra e a categoria do cliente (1 para comum, 2 para associado e 3 para VIP).
            Console.Write("Qual foi o valor da compra: ");
            double compra = double.Parse(Console.ReadLine());

            Console.Write("Qual a categoria do cliente '1'comum, '2'associado, '3'Vip: ");
            int categoria = int.Parse(Console.ReadLine());

            switch (categoria)
            {
                case 1: 
                    Console.WriteLine("A categoria "+categoria+ " é um cliente comum, pagara o valor cheio  de R$"+compra);
                    break;
                case 2:
                     compraDesconto = compra - (10d / 100 * compra);
                    Console.WriteLine(compraDesconto);
                    Console.WriteLine("A categoria " + categoria + " é um cliente Associado, e pagara um valor com 10% de desconto que sera "+compraDesconto);
                    break;
                case 3:
                     compraDesconto = compra - (20d / 100 * compra);
                    Console.WriteLine("A categoria " + categoria + " é um cliente VIP, e pagara um valor com 10% de desconto que sera " + compraDesconto);
                    break;
            }

            Console.ReadKey();
        }
    }
}
