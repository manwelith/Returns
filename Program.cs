using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnDeger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int toplanandeger = toplamaYap(4, 5);

            if (toplanandeger>10)
            {
                Console.WriteLine("Sonuç 10dan Büyüktür.");
            }
            else
            {
                Console.WriteLine("Sonuç 10dan Küçüktür.");
            }*/
            IsimSoyisim("Soner", "Arı");
            


            Console.ReadLine();
        }
        /*static int toplamaYap(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        }*/

        static string IsimSoyisim(string isim, string soyisim)
        {
            string toplam = isim  +" "+  soyisim;
            Console.WriteLine(toplam);

            return toplam;

        }


    }
}
