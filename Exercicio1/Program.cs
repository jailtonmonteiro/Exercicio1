using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s;


            Console.WriteLine("Digite o valor 1: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2: ");
            b = int.Parse(Console.ReadLine());

            s = a + b;

            Console.WriteLine("Soma = " + s);
        }
    }
}