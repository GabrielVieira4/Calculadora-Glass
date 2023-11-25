using System;
using Microsoft.VisualBasic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Calculadora Glass - Escolha uma operação matematica:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Fechar Calculadora Glass");
            Console.WriteLine("*********************");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());
            Console.ReadKey();

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 + valor2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 - valor2;

            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 / valor2;

            Console.WriteLine($"O resultado da Divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 * valor2;

            Console.WriteLine($"O resultado da Multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Sair()
        {
            Console.WriteLine("Obrigado por utilizar os nossos serviços e lembre-se: Calculadora Glass é o nome certo!");
        }

    }
}