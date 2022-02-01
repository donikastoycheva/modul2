using System;

namespace sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n >= 3 && n <= 100)
            {
                Console.Write(new string('*', 2 * n));
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', 2 * n));

                for (int i = 0; i < n - 2; i++)
                {
                    // TODO: print *///////*
                    if (i == (n - 1) / 2 - 1)
                        Console.Write(new string('|', n));
                    else
                        Console.Write(new string(' ', n));
                    // TODO: print *///////*
                    Console.WriteLine();

                }

                Console.Write(new string('*', 2 * n));
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', 2 * n));
            }
        }
    }
}
