using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci = new ogrenci(); // classın objesini olusturduk, yani initalization // instance// bütün classlar referans tiplerdir
            //ogrenci.memleket = "Ankara";// yanlıs
            //ogrenci.setAdi("Çağıl");
            ogrenci.Memleket = ("Ankara");
            //Console.WriteLine(ogrenci.GetAd() + " - " + ogrenci.Memleket);
            

            ogrenci yeniOgrenci = new ogrenci();
           // yeniOgrenci.setAdi("Neşe");
            yeniOgrenci.Memleket = ("İzmir");
            yeniOgrenci.KartNo = "1234 5678 9012 3456";
            //Console.WriteLine(yeniOgrenci.GetAd() + " - " + yeniOgrenci.Memleket);
            Console.WriteLine(yeniOgrenci.KartNo);

            ogrenci tembelOgrenci = new ogrenci();
            tembelOgrenci.Ad = "Çağıl";
            tembelOgrenci.Soyad = "Alsaç";
            Console.WriteLine(tembelOgrenci.AdSoyad);


            ogrenci calıskanOgrenci = new ogrenci()
            {
                Ad = "Ali",
                Soyad = "Vefa",
                Memleket = "İstanbul",
                erkekMi = true
                
            };

            Console.WriteLine(calıskanOgrenci.AdSoyad + " - " + calıskanOgrenci.Memleket);
            int[] numbers = { 1, 2, 3 };
            int length = numbers.Length;

            Console.ReadLine();
        }
    }
    class ogrenci
    {
        //string _ad; // field // alan
        //string _soyad;
        //int yas;

        string _kartNo;

        public string KartNo
        {
            //get
            //{
            //    return " **** **** ****" + _kartNo.Substring(15);
            //}
            //set
            //{
            //    _kartNo = value;
            //}
            get => " **** **** ****" + _kartNo.Substring(15);  // yukardakiyle aynı işlev ve daha kolayı
            set => _kartNo = value;
        }



        public string Memleket { get; set; } // özellik, property// prop tabx2

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AdSoyad // read only
        {
            get
            {
                return Ad + " " + Soyad;
            }


            //public string memleket; // field// yanlıs

            //encapsulation****** // önemli bir olay

            //public void setAdi(string ad) // method, davranış, behavior
            //{
            //    _ad = ad;
            //}

            //public string GetAd()
            //{
            //    return _ad;
            //}

        }
        public bool erkekMi { get; set; }

        public string unvan
        {
            get
            {
                return erkekMi ? "Bay" : "Bayan";
            }
        }
    }
}
