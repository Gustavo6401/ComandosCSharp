using System;

namespace Comandos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        void Declaracao () 
        {
            int a;
            int b = 2; int c = 3;
            const int d = 4;

            a = 1;

            Console.WriteLine(a + b + c + d);
        }
        void InstrucaoIf(string[] args) 
        {
            if (args.Length == 0) 
            {
                Console.WriteLine("Nenhum Argumento");
            }
            else if (args.Length == 1) 
            {
                Console.WriteLine("Um Argumento");
            }
            else 
            {
                Console.WriteLine($"{args.Length} argumentos"); 
            }
        }
        void InstrucaoSwitch(string[] args) 
        {
            int numeroDeArgumentos = args.Length;

            switch(numeroDeArgumentos) 
            {
                case 0:
                    Console.WriteLine("Nenhum Argumento");
                    break;

                case 1:
                    Console.WriteLine("Um Argumento");
                    break;

                default:
                    Console.WriteLine($"{numeroDeArgumentos} Argumentos");
                    break;
            }            
        }
        void InstrucaoWhile(string[] args)
        {
            int i = 0;

            while(i < args.Length) 
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }
        void InstrucaoDo(string[] args) 
        {
            string texto;

            do 
            {
                texto = Console.ReadLine();

                Console.WriteLine(texto);
            } while (!string.IsNullOrWhiteSpace(texto));
        }
        void InstrucaoFor(string[] args) 
        {
            int i = 0;

            for (i; i < args.Length; i++) 
            {
                Console.WriteLine(args[i]);
            }
        }
        void InstrucaoForeach(string[] args) 
        {
            foreach (string s in args) 
            {
                Console.WriteLine(s);
            }
        }
        void InstrucaoBreak(string[] args) 
        {
            while (true) 
            {
                string s = Console.ReadLine();
                
                if(string.IsNullOrWhiteSpace(s)) 
                {
                    break;          
                }      

                Console.WriteLine(s);
            }
        }
        void InstrucaoContinue(string[] args) 
        {
            int i = 0;

            for (i; i < args.Length; i++) 
            {
                if(args[i].StartsWith("/")) 
                {
                    continue;
                }
                else 
                {
                    Console.WriteLine(args[i]);
                }
            }
        }
        void InstrucaoReturn(string[] args) 
        {
            int Somar (int a, int b) 
            {
                return a + b;
            }
            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));

            return;
        }
        void InstrucoesTryCatchFinallyThrow(string[] args) 
        {
            double Dividir(float a, float b)             
            {
                if (b == 0) 
                {
                    throw new DivideByZeroException();
                }
                return a / b;
            }

            try 
            {
                if (args.Length != 2) 
                {
                    throw new InvalidOperationException("Informe 2 Números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);

                Console.WriteLine(Dividir(x, y));                
            }
            catch (InvalidOperationException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Genérico {ex.Message}");
            }
            finally 
            {
                Console.WriteLine("Até Breve!");
            }
        }
        void InstrucaoUsing(string[] args) 
        {
            using(System.IO.TextWriter w = System.IO.File("teste.txt")) 
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}
