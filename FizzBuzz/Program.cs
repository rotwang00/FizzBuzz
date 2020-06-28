using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How high should fizzbuzz go? ");
            string response = Console.ReadLine();
            int limit = Convert.ToInt32(response);
            
            for (int i = 1; i <= limit; i++)
            {
                bool multiple = false;

                if (i % 3 == 0) {
                    Console.Write("fizz");
                    multiple = true;
                }

                if (i % 5 == 0) {
                    Console.Write("buzz");
                    multiple = true;
                }

                if (multiple == false) {
                    Console.Write(i);
                }

                Console.WriteLine("");
            }
        }
    }
}
