using System;

namespace koledni_podaruci
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            if(budget >= 0.01 && budget <= 1000 &&
                price >= 0.01 && price <= 1000)
            {
                var price2 = price * 0.2;
                var price3 = price2 * 0.7;
                var price4 = price2 * 0.5;
                var sum = price + price2 + price3 + price4;

                if (budget >= sum)
                {
                    var wow = budget - sum;
                    Console.Write("Yes! {0:f2}", wow );
                    Console.WriteLine(" leva left.");
                }
                else
                {
                    var wow = sum - budget;
                    Console.Write("No! {0:f2}", wow);
                    Console.WriteLine(" leva needed.");
                }
            }
        }
    }
}
