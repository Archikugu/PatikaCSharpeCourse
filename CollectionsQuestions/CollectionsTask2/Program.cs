using System;

namespace CollectionsTask2
{
    internal class Program
    {
        /*
         Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
         her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
         (Array sınıfını kullanarak yazınız.)
         */
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int enBuyukToplam = 0, enKucukToplam = 0;

            Console.WriteLine("Lüften 20 tane Sayı Giriniz");
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Sayı {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out sayilar[i]))
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                    i--;
                }
            }

            Array.Sort(sayilar);

            Console.WriteLine("En Küçük 3 Sayı:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sayilar[i]);
                enKucukToplam += sayilar[i];
            }

            Console.WriteLine("En Büyük 3 Sayı:");
            for (int i = 19; i >= 17; i--)
            {
                Console.WriteLine(sayilar[i]);
                enBuyukToplam += sayilar[i];
            }

            double ortEnBuyuk = (double)enBuyukToplam / 3;
            double ortEnKucuk = (double)enKucukToplam / 3;
            double toplamOrt = (ortEnBuyuk + ortEnKucuk) / 2;

            Console.WriteLine($"\nEn Büyük 3 Sayıların Ortalaması: {ortEnBuyuk}");
            Console.WriteLine($"En Küçük 3 Sayıların Ortalaması: {ortEnKucuk}");
            Console.WriteLine($"Her İki Grubun Ortalaması: {toplamOrt}");
            Console.WriteLine($"Toplam Ortalama: {toplamOrt * 2}");
        }
    }
}
