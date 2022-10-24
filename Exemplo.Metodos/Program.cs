using System;

namespace Exemplo.Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal somaUm = Calculadora
                .Somar(15.15m, 12.13m);

            Console.WriteLine("Soma um: " + somaUm);

            decimal somaDois = Calculadora
                .Somar(11.23m, 13.26m, 33.63m);

            Console.WriteLine("Soma dois: " + somaDois);

            Console.WriteLine("Subtração: "
                + Calculadora.Subtrair(15.23m, 12.23m));

            Console.WriteLine("Subtração: "
                + Calculadora.Subtrair(15.23m, 12.23m, 1.00m));

            Console.WriteLine("Subtração: "
                + Calculadora.Subtrair(15.23m, -12.23m, -10.00m));

            Console.ReadKey();
        }
    }
}