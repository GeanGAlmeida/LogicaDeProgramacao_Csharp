using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia a nota de um aluno e converta-a para conceito: A (nota >= 9), B (7 <= nota < 9),
             * C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3).*/

            Console.Write("Informe sua nota: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 9)
            {
                Console.WriteLine("Sua nota " +  nota + " é equivalente a A");
            }
            else if (nota >= 7 && nota < 9)
            {
                Console.WriteLine("Sua nota " + nota + " é equivalente a B");
            }
            else if (nota >= 5 && nota < 7)
            {
                Console.WriteLine("Sua nota " + nota + " é equivalente a C");
            }
            else if(nota >= 3 && nota < 5)
            {
                Console.WriteLine("Sua nota " + nota + " é equivalente a D");
            }
            else
            {
                Console.WriteLine("Sua nota " + nota + " é equivalente a F");
            }

            Console.ReadKey();
        }
    }
}
