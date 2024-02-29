using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a non-negative integer: ");
            string input = Console.ReadLine();

            byte n = (int.Parse(input) && input >= 0);
            Console.WriteLine($"Resultado da operação de decremento de {n}: {--n}");
            Console.WriteLine($"Resultado da operação de incremento de {n}: {++n}");
            Console.WriteLine($"Divisão por 2 de {n}: {n/2}");
            Console.WriteLine($"Shift left por 3 de {n}: {n<<3}");
            Console.WriteLine($"Xor com 5 de {n}: {n^5}");
            Console.WriteLine($"É maior que 10? {n>10}");
        }
    }
}
