using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDemoEtud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.PI);
            int sayi1, sayi2;
            sayi1 = 10;
            sayi2 = 20;
            int fark = sayi1 - sayi2; //-10
            int mutlak = Math.Abs(fark); // 10

            double sayi3 = 2.4;
            Console.WriteLine(Math.Ceiling(sayi3) + " - " + Math.Floor(sayi3)); // floor ağağıya ceiling yukarıya yuvarlar

            Console.WriteLine(Math.Pow(2, 4)); // pow üzeri sayılar // 2 üzeri 4 = 16
            Console.WriteLine(Math.Max(sayi1, sayi2) + " - " + Math.Min(sayi1, sayi2)); // 20-10

            double sayi4 = 12.345;
            double sayi5 = 98.765;
            Console.WriteLine(Math.Round(sayi4) + " - " + Math.Round(sayi5));
            Console.WriteLine(Math.Round(sayi4,1) + " - " + Math.Round(sayi5, 1));
            Console.WriteLine(Math.Round(sayi4,2) + " - " + Math.Round(sayi5, 2));

            Console.WriteLine(Math.Sqrt(4) + " - " + Math.Pow(8, 1.0/3.0)); // 2 // kare kök demek//

            Console.Write("Doğum Tarihi (gg.aa.yyyy: ");
            string dogumTarihiUnput = Console.ReadLine();
            DateTime dogumTarihi = DateTime.Parse(dogumTarihiUnput, new CultureInfo("tr"));
            DateTime bugununTarihi = DateTime.Today;
            //int yas = bugununTarihi.Year - dogumTarihi.Year;
            TimeSpan tarihFarki = bugununTarihi -dogumTarihi;
            double yas = tarihFarki.TotalHours / (365 * 24 + 6);


            Console.WriteLine("yaş: " + Math.Floor(yas));


            Console.ReadLine();
        }
    }
}
