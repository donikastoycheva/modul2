using System;

namespace postavqne_na_laminat
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceLaminat = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var pricePad = double.Parse(Console.ReadLine());

            if (priceLaminat >= 0 && priceLaminat <= 999 &&
                width >= 0 && width <= 999 &&
                length >= 0 && length <= 999 &&
                pricePad >= 0 && pricePad <= 999)
            {
                var S = width * length;
                var laminat = S * priceLaminat;
                var pad = S * pricePad;
                var montaj = 0.4 * (laminat + pad);
                var all = laminat + pad + montaj;

                Console.WriteLine("{0:f2}", all);
            }
        }
    }
}
