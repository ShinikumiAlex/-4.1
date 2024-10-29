using System;

namespace Компьютерный_практикум__4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
                int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
                int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
                int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"a+b+c = {a + b + c}");
            Console.ReadKey();
        }
    }
}
