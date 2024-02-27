using System;
using System.Collections;

namespace CollectionsTask1
{
    internal class Program
    {
        /*
         Task-1

        Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

        Negatif ve numeric olmayan girişleri engelleyin.
        Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

         */
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();
            int toplamAsal = 0, toplamAsalOlmayan = 0, asalSayac = 0, asalOlmayanSayac = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Pozitif bir sayı giriniz: ");
                if (int.TryParse(Console.ReadLine(), out int sayi) && sayi > 0)
                {
                    if (AsalMi(sayi))
                    {
                        asalSayilar.Add(sayi);
                        toplamAsal += sayi;
                        asalSayac++;
                    }
                    else
                    {
                        asalOlmayanlar.Add(sayi);
                        toplamAsalOlmayan += sayi;
                        asalOlmayanSayac++;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı giriniz.");
                    i--;
                }
            }

            asalSayilar.Sort();
            asalSayilar.Reverse();
            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();

            Console.WriteLine("Asal Sayılar:");
            foreach (int sayi in asalSayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine($"Toplam asal sayılar: {asalSayac}");
            if (asalSayac > 0)
                Console.WriteLine($"Ortalama asal sayı: {(double)toplamAsal / asalSayac}");

            Console.WriteLine("Asal Olmayan Sayılar:");
            foreach (int sayi in asalOlmayanlar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine($"Toplam asal olmayan sayılar: {asalOlmayanSayac}");
            if (asalOlmayanSayac > 0)
                Console.WriteLine($"Ortalama asal olmayan sayı: {(double)toplamAsalOlmayan / asalOlmayanSayac}");
        }
        static bool AsalMi(int sayi)
        {
            if (sayi <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                    return false;
            }
            return true;
        }
    }
}

