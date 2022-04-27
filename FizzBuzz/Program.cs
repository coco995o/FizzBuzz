using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 4 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 4 != 0 || number % 3 != 0)
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
    }
}
