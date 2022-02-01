using System;

namespace zemetreseniq
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double lightc = 0;
            double moderatec = 0;
            double strongc = 0;
            double verystrongc = 0;
            for (int i=0; i<n; i++)
            {
                var cat = double.Parse(Console.ReadLine());
                
                    if (cat >=0 && cat <= 4)
                    {
                        lightc++;
                    }
                    else if (cat > 4 && cat <= 6)
                    {
                        moderatec++;
                    }
                    else if (cat > 6 && cat <=7)
                    {
                        strongc++;
                    }
                    else if (cat > 7)
                    {
                        verystrongc++;
                    }         
            }
            var light = (lightc / n) * 100;
            var moderate = (moderatec / n) * 100;
            var strong = (strongc / n) * 100;
            var verystrong = (verystrongc / n) * 100;
            Console.Write("Light: {0:f2}", light);
                Console.WriteLine("%");
                Console.Write("Moderate: {0:f2}", moderate);
                Console.WriteLine("%");
                Console.Write("Strong: {0:f2}", strong);
                Console.WriteLine("%");
                Console.Write("Very Strong: {0:f2}", verystrong);
                Console.WriteLine("%");
        }


        }
    }
    

