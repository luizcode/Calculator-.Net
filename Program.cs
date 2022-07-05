using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            LimpaConsole();
            int opcao;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1- Adição");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação");
                Console.WriteLine("4- Divisão");
                Console.WriteLine("5- Sair");
                opcao = LerOpcao();

                if(opcao == 1)
                {
                    Soma();
                }else if(opcao == 2)
                {
                    Subtrair();
                }else if ( opcao == 3)
                {
                    Multiplicar();
                }else if (opcao == 4)
                {
                    Divisao();
                }
            }while(opcao != 5);

            LimpaConsole();
            Console.WriteLine("Saindo");
            System.Environment.Exit(0);
        }

        static void LimpaConsole() { 
            Console.Clear();
        }

        static void Soma() { 
            LimpaConsole();
            Console.WriteLine("Qual o primeiro valor?");
            var v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo valor?");
            var v2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma entre {v1} e {v2} é {v1+v2}");
        }

        static void Multiplicar()
        {
            LimpaConsole();
            Console.WriteLine("Qual o primeiro valor?");
            var v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo valor?");
            var v2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A multiplicação entre {v1} e {v2} é {v1*v2}");
        }

        static void Subtrair()
        {
            LimpaConsole();
            Console.WriteLine("Qual o primeiro valor?");
            var v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo valor?");
            var v2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A subtração entre {v1} e {v2} é {v1-v2}");
        }

        static void Divisao()
        {
            LimpaConsole();
            Console.WriteLine("Qual o primeiro valor?");
            var v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo valor?");
            var v2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"A divisão entre {v1} e {v2} é {v1/v2}");
        }

        static int LerOpcao()
        {
            var opcao = int.Parse(Console.ReadLine());
            return opcao;
        }
    }
}
