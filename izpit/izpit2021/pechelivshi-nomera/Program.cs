using System;

namespace pechelivshi_nomera
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i <= 9; i++)
            {
                for (int o = 0; o <= 9; o++)
                {
                    for (int p = 0; p <= 9; p++)
                    {
                        for (int l = 0; l <= 9; l++)
                        {
                            if (i + l == n)
                            {
                                if (o % 2 != 0)
                                {
                                    if (p == 4 || p == 7)
                                        Console.Write("{0}{1}{2}{3} ", i, o, p, l);
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

