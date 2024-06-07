using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que leia três notas de um aluno e calcule a média.
          * Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5)*/

            Console.WriteLine("Veja se o aluno esta aprovado ou reprova com a média de suas notas");
            Console.WriteLine("Digite a primeira nota do aluno");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno");
            float nota3 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2 + nota3) / 3;

            if (media < 5)
            {
                Console.WriteLine("O aluno foi reprovado com media "+media);
            }
            else if(media >= 5 && media < 7)
            {
                Console.WriteLine("O aluno esta de recuperação com media " + media);
            }
            else
            {
                Console.WriteLine("O aluno foi aprovado com media "+media);
            }

            Console.ReadKey();
        }
    }
}
