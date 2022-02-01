using System;

namespace dograma
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var name = Console.ReadLine();

            if (width >= 0 && width <= 999 &&
                length >= 0 && length <= 999 &&
                n >= 3 && n <= 5 &&
                name == "Dogramichka4You" || name == "TihoToplo" || name == "ChukChuk")
            {
                var S = width * length;
               
                if (name == "Dogramichka4You")
                {
                    if (n == 3)
                    {
                         var all = S * 12;
                        Console.Write("Goshko has to spend {0:f2}", all);                      
                    }
                    if (n == 4)
                    {
                        var all = S * 15;
                        Console.Write("Goshko has to spend {0:f2}", all);
                    }
                    if (n == 5)
                    {
                        var all = S * 20;
                        Console.Write("Goshko has to spend {0:f2}", all);
                    }
                }
                if (name == "TihoToplo")
                {
                    if (n == 3)
                    {
                        var all = S * 15;
                        Console.Write("Goshko has to spend {0:f2}", all);
                    }
                    if (n == 4)
                    {
                        var all = S * 14;
                        Console.Write("Goshko has to spend {0:f2}", all);
                    }
                    if (n == 5)
                    {
                        var all = S * 18;
                        Console.Write("Goshko has to spend {0:f2}", all);
                    }
                }
                if (name == "ChukChuk")
                {
                    if (n == 3)
                    {
                        var all = S * 14;
                        Console.Write("Goshko has to spend {0:f2}", all);
                    }
                    if (n == 4)
                    {
                        var all = S * 20;
                        Console.Write("Goshko has to spend {0:f2}", all);
                    }
                    if (n == 5)
                    {
                        var all = S * 22;
                        Console.Write("Goshko has to spend {0:f2}", all);
                    }
                }
                Console.WriteLine(" leva.");

            }

        }
    }
}
