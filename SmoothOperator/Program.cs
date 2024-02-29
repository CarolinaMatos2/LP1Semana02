using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a non-negative integer: ");
            string input = Console.ReadLine();

            byte n = (byte)(int.TryParse(str) && userInput >= 0);
            Console.WriteLine($"Resultado da operação de decremento de {n}: {--n}");
            Console.WriteLine($"Resultado da operação de incremento de {n}: {++n}");
            
        }
    }
}
