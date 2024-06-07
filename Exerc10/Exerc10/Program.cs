using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculadora usando Switch
            Console.WriteLine("Calculadora simples");

            Console.Write("Digite o primeiro numero: \n");
            double num1 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o primeiro numero: \n");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Informe o operação que voce deseja usar '+' '-' '*' '/': ");
            string operacao = Console.ReadLine();

            switch (operacao) 
            {
                case "+":
                    double soma = num1 + num2;
                    Console.WriteLine("A soma de " + num1 + " + " + num2 +" é " + soma);
                    break;
                case "-":
                    double sub = num1 - num2;
                    Console.WriteLine("A subtração de " + num1 + " - " + num2 + " é " + sub);
                    break;
                case "*":
                     double mult = num1 * num2;
                    Console.WriteLine("A multiplicação de " + num1 + " X " + num2 + " é " + mult);
                    break;
                case "/":
                    double div = num1 / num2;
                    Console.WriteLine("A divisão de " + num1 + " / " + num2 + " é " + div);
                    break;
                default: Console.WriteLine("Essa operação não esta disponivel");
                    break;
            }
            Console.ReadKey();
        }
    }
}
