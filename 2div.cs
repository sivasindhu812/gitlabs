using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number:");
            n = Int32.Parse(Console.ReadLine());

            if ( n % 2 == 0)
            {
                Console.WriteLine($"{n} is divisible by 2");
            }
            else
            {
                Console.WriteLine($"{n} is not divisible by 2");
            }
            
        }
    }
}


