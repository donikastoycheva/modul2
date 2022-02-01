using System;

namespace equal_pairs_ofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var beforeSum = 0;
            var dif = 0;



            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    var firstNum1 = int.Parse(Console.ReadLine());
                    var secondNum2 = int.Parse(Console.ReadLine());
                    beforeSum = firstNum1 + secondNum2;
                }   
                else
                {
                    var firstNum2 = int.Parse(Console.ReadLine());
                    var secondNum2 = int.Parse(Console.ReadLine());
                    var afterSum = firstNum2 + secondNum2;

                    if ((Math.Abs(afterSum - beforeSum)) > dif)
                    {
                        dif = Math.Abs(afterSum - beforeSum);
                    }
                    beforeSum = afterSum;
                }                
            }
            if (dif > 0)
            {
                Console.WriteLine("No, maxdiff=" + dif);
            }
            else
            {
                Console.WriteLine("Yes, value=" + beforeSum);
            }


        }
    }
}
