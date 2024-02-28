using System;

namespace PhoneDirectory
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            TelefonRehberi rehber = new TelefonRehberi();

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Lütfen isim giriniz:");
                        string isim = Console.ReadLine();
                        Console.WriteLine("Lütfen soyisim giriniz:");
                        string soyisim = Console.ReadLine();
                        Console.WriteLine("Lütfen telefon numarası giriniz:");
                        string telefon = Console.ReadLine();
                        rehber.NumaraKaydet(isim, soyisim, telefon);
                        break;
                    case "2":
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını veya soyadını giriniz:");
                        string adSoyadSil = Console.ReadLine();
                        rehber.NumaraSil(adSoyadSil);
                        break;
                    case "3":
                        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını veya soyadını giriniz:");
                        string adSoyadGuncelle = Console.ReadLine();
                        rehber.NumaraGuncelle(adSoyadGuncelle);
                        break;
                    case "4":
                        Console.WriteLine("Rehberi A-Z sıralamak için 'A' veya Z-A sıralamak için 'Z' girin:");
                        char siralamaYonu = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        rehber.RehberListele(siralamaYonu);
                        break;
                    case "5":
                        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
                        Console.WriteLine("(1) İsim veya soyisime göre arama yapmak");
                        Console.WriteLine("(2) Telefon numarasına göre arama yapmak");
                        int aramaTipi = int.Parse(Console.ReadLine());
                        rehber.RehberArama(aramaTipi);
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}
