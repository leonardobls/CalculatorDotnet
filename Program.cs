using System;

namespace CalculatorDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Limpa o terminal ao inicio
            Console.WriteLine("/*----------------------------\nBem vindo a calculadora!\n");

            while (true)
            {
                Console.WriteLine("\nPara realizar uma operação aritmética simples, escolha uma das opções:\n\n1 - Somar\n2 - Subtrair\n3 - Dividir\n4 - Multiplicação\n0 - Sair\n");

                Console.Write("Sua alternativa: ");

                int valor = int.Parse(Console.ReadLine());
                int stop = 1;
                switch (valor)
                {
                    case 0:
                        stop = 0;
                        break;

                    case 1:
                        Soma();
                        Console.WriteLine("Deseja fazer uma nova operação? (1 - sim / 0 - não)");
                        stop = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Subtracao();
                        Console.WriteLine("Deseja fazer uma nova operação? (1 - sim / 0 - não)");
                        stop = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Divisao();
                        Console.WriteLine("Deseja fazer uma nova operação? (1 - sim / 0 - não)");
                        stop = int.Parse(Console.ReadLine());
                        break;

                    case 4:
                        Multiplicacao();
                        Console.WriteLine("Deseja fazer uma nova operação? (1 - sim / 0 - não)");
                        stop = int.Parse(Console.ReadLine());
                        break;
                }

                if (stop != 1)
                {
                    Console.WriteLine("Encerrando...");
                    break;
                }
            }
        }

        static void Soma()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine());

            double resultado = primeiroValor + segundoValor;

            // Console.WriteLine("\nO resultado da soma: " + resultado);
            Console.WriteLine($"\nResultado: {resultado}");
            // Console.WriteLine($"\nO resultado da soma: {primeiroValor + segundoValor}");
            // Console.WriteLine("\nO resultado da soma: " + (primeiroValor + segundoValor));
        }

        static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("\nResultado: " + (primeiroValor - segundoValor));
        }

        static void Divisao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine());

            if (segundoValor == 0)
            {
                Console.WriteLine("\n\t***Não é possível fazer divisão por zero!***\n");
            }
            else
            {
                Console.WriteLine("\nResultado: " + (primeiroValor / segundoValor));
            }
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("\nResultado: " + (primeiroValor * segundoValor));
        }
    }
}