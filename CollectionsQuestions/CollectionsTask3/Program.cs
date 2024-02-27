using System;
using System.Collections.Generic;

namespace CollectionsTask3
{
    internal class Program
    {
        /*
         Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
         */
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            List<char> sesliHarfler = new List<char>();

            foreach (char harf in cumle)
            {
                if (IsSesliHarf(harf))
                {
                    sesliHarfler.Add(harf);
                }
            }

            // Sesli harfleri sırala
            sesliHarfler.Sort();

            // Sonucu ekrana yazdır
            Console.WriteLine("Girilen cümledeki sesli harfler:");
            foreach (char sesliHarf in sesliHarfler)
            {
                Console.WriteLine(sesliHarf);
            }
        }

        static bool IsSesliHarf(char harf)
        {
            harf = char.ToLower(harf);
            return harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'o' || harf == 'ö' || harf == 'u' || harf == 'ü';
        }
    }
}

