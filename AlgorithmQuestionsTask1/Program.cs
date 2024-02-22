using System;

namespace AlgorithmQuestionsTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Task2();

            Task3();

            Task4();
        }

        private static void Task4()
        {
            // Kullanıcıdan bir cümle girmesini isteyin
            Console.WriteLine("Lütfen bir cümle girin:");
            string cumle = Console.ReadLine();

            // Kelime ve harf sayılarını tutacak değişkenleri tanımlayın
            int kelimeSayisi = 0;
            int harfSayisi = 0;

            // Cümleyi boşluklara göre parçalayarak kelimeleri bulun
            string[] kelimeler = cumle.Split(' ');

            // Her kelimenin harf sayısını toplam harf sayısına ekleyin
            foreach (string kelime in kelimeler)
            {
                harfSayisi += kelime.Length;
                kelimeSayisi++;
            }

            // Sonuçları console'a yazdırın
            Console.WriteLine($"Toplam kelime sayısı: {kelimeSayisi}");
            Console.WriteLine($"Toplam harf sayısı: {harfSayisi}");
        }

        private static void Task3()
        {
            // Kullanıcıdan pozitif bir sayı girmesini isteyin (n)
            Console.WriteLine("Lütfen pozitif bir sayı girin:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Kullanıcının gireceği kelimeleri tutmak için bir dizi oluşturun
            string[] kelimeler = new string[n];

            // Kullanıcıdan n adet kelime girmesini isteyin ve dizide ters sırayla saklayın
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. kelimeyi girin:");
                kelimeler[i] = Console.ReadLine();
            }

            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın
            Console.WriteLine("Girdiğiniz kelimelerin ters sırayla listesi:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }
        }

        private static void Task2()
        {
            Console.WriteLine("Lütfen pozitif iki sayı girin (n, m):");
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            // Kullanıcının gireceği sayıları tutmak için bir dizi oluşturun
            int[] sayilar = new int[n];

            // Kullanıcıdan n adet pozitif sayı girmesini isteyin ve diziye ekleyin
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. sayıyı girin:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            // m'e eşit veya tam bölünen sayıları console'a yazdırın
            Console.WriteLine($"Girdiğiniz sayılardan {m}'e eşit veya tam bölünenler:");
            foreach (int sayi in sayilar)
            {
                if (sayi % m == 0)
                {
                    Console.WriteLine(sayi);
                }
            }
        }

        private static void Task1()
        {
            // Kullanıcıdan pozitif bir sayı girmesini isteyin
            Console.WriteLine("Lütfen pozitif bir sayı girin:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Kullanıcının gireceği sayıları tutmak için bir dizi oluşturun
            int[] sayilar = new int[n];

            // Kullanıcıdan n adet pozitif sayı girmesini isteyin ve diziye ekleyin
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. sayıyı girin:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Çift sayıları console'a yazdırın
            Console.WriteLine("Girdiğiniz çift sayılar:");
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }
        }
    }
}
