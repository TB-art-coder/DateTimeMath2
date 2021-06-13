using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMath2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime simdikiTarih = DateTime.Now;
            Console.WriteLine(simdikiTarih);
            Console.WriteLine(simdikiTarih.ToShortDateString()); // Anlık tarih 13.06.2021
            Console.WriteLine(simdikiTarih.ToLongDateString()); // 13 haziran 2021 pazar
            Console.WriteLine(simdikiTarih.ToShortTimeString()); // 15.10 // saat kısmı
            Console.WriteLine(simdikiTarih.ToLongTimeString()); // 15.10.56 saniye ekler
            Console.WriteLine(simdikiTarih.ToLongTimeString() + " " + simdikiTarih.ToLongTimeString()); // ilk satırla aynı sey
            Console.WriteLine(simdikiTarih.Day + ". " + simdikiTarih.Month + ". " + simdikiTarih.Year + ". " + simdikiTarih.Hour + ": " + simdikiTarih.Minute + ": " + simdikiTarih.Second);

            DateTime tarih1 = new DateTime(2020, 9, 30); // 0001-01-01 00:00:00.000 tarih ve zamanı bu sekile algılar, 2020.09.30
            Console.WriteLine(tarih1);
            DateTime tarih2 = new DateTime(2020, 9, 30, 7, 45, 0, 0);
            Console.WriteLine(tarih2);

            DateTime tarih3 = DateTime.Parse("13.06.2020", new CultureInfo("tr"));
            DateTime tarih4 = DateTime.Parse("06/30/2021", new CultureInfo("en"));

            Console.WriteLine(tarih3);
            Console.WriteLine(tarih4);

            Console.WriteLine(tarih3.ToString(new CultureInfo("en"))); // 06/13/2020
            Console.WriteLine(tarih4.ToString("yyyy-MM-dd-HH:mm:ss"));

            simdikiTarih = DateTime.Now;
            Console.WriteLine(simdikiTarih.AddDays(1)); // yarının tarihini yazar
            Console.WriteLine(simdikiTarih.AddMonths(-6)); // 6 ay öncesini yazar
            // addhours veya years gibi komutlarla da aynı şekilde yazdırabilirsin

            var tarih11 = DateTime.Parse("01.10.2020");
            var tarih22 = DateTime.Parse("20.10.2020");
            //if (tarih11.CompareTo(tarih22) > 0)                  AŞAĞIDAKİ KOMUTLARLA BİREBİR AYNI ESKİ KULLANIM VERSİYONU DİYEBİLİRİZ
            //    Console.WriteLine("tarih11 > tarih22");
            //else if (tarih11.CompareTo(tarih22) < 0)
            //    Console.WriteLine("tarih11 < tarih22");
            //else // tarih11.compareTo(tarih22) == 0
            //    Console.WriteLine("tarih11 = tarigh22");


            if (tarih11 > tarih22)
                Console.WriteLine("tarih11 > tarih22");
            else if (tarih11 < tarih22)
                Console.WriteLine("tarih11 < tarih22");
            else
                Console.WriteLine("tarih11 = tarigh22");

            simdikiTarih = DateTime.Now;
            Console.WriteLine(simdikiTarih.DayOfWeek +"(" + (int)simdikiTarih.DayOfWeek + ")");
            Console.WriteLine(simdikiTarih.DayOfYear); // 164
            Console.WriteLine(simdikiTarih.Ticks);

            Console.WriteLine(simdikiTarih.Date);
            Console.WriteLine(DateTime.Today);





            Console.ReadLine();

        }
    }
}
