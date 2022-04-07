using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayılzrı ekrana yazdır.
            /* Console.WriteLine("Lütfen bir sayı giriniz");
             int sayac = int.Parse(Console.ReadLine());
             for (int i = 1; i <= sayac; i++)
             {
                 //komutlar
                 if (i % 2 == 1)
                 {
                     Console.WriteLine(i);
                 }
             }
            */
            //1ile100 arasındaki tek ve çift sayılarının kendi içlerinde toplamı ekrana yazdır
/*        int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i; // tektoplam = tektoplam + i;
                }
                else
                {

                }
                ciftToplam += i;

            }
            Console.WriteLine("Tek Toplam : " + tekToplam);
            Console.WriteLine("Çift toplam : " + ciftToplam);

 */
            //Break, Continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}
