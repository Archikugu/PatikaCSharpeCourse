using System;
using static PhoneDirectory.Program;
using System.Collections.Generic;
using System.Linq;

namespace PhoneDirectory
{
    public class TelefonRehberi
    {
        List<RehberKayit> rehber = new List<RehberKayit>();

        public TelefonRehberi()
        {
            rehber.Add(new RehberKayit { Isim = "Ahmet", Soyisim = "Yılmaz", TelefonNumarasi = "1234567890" });
            rehber.Add(new RehberKayit { Isim = "Mehmet", Soyisim = "Kaya", TelefonNumarasi = "9876543210" });
            rehber.Add(new RehberKayit { Isim = "Arda", Soyisim = "Dayantürk", TelefonNumarasi = "145678965" });
            rehber.Add(new RehberKayit { Isim = "Enes", Soyisim = "Özsöz", TelefonNumarasi = "4567891254" });
            rehber.Add(new RehberKayit { Isim = "Gökhan", Soyisim = "Gök", TelefonNumarasi = "0123456789" });      
        }

        public void NumaraKaydet(string isim, string soyisim, string telefonNumarasi)
        {
            rehber.Add(new RehberKayit { Isim = isim, Soyisim = soyisim, TelefonNumarasi = telefonNumarasi });
            Console.WriteLine("Numara başarıyla kaydedildi.");
        }

        public void NumaraSil(string adSoyad)
        {
            RehberKayit silinecekKisi = rehber.Find(kisi => kisi.Isim.Equals(adSoyad) || kisi.Soyisim.Equals(adSoyad));
            if (silinecekKisi == null)
            {
                Console.WriteLine("Aradığınız kişi rehberde bulunamadı.");
                return;
            }

            Console.WriteLine($"{silinecekKisi.Isim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
            string onay = Console.ReadLine();
            if (onay.ToLower() == "y")
            {
                rehber.Remove(silinecekKisi);
                Console.WriteLine("Kişi rehberden silindi.");
            }
            else
            {
                Console.WriteLine("İşlem iptal edildi.");
            }
        }

        public void NumaraGuncelle(string adSoyad)
        {
            RehberKayit guncellenecekKisi = rehber.Find(kisi => kisi.Isim.Equals(adSoyad) || kisi.Soyisim.Equals(adSoyad));
            if (guncellenecekKisi == null)
            {
                Console.WriteLine("Aradığınız kişi rehberde bulunamadı.");
                return;
            }

            Console.WriteLine($"Lütfen yeni telefon numarasını giriniz:");
            string yeniTelefon = Console.ReadLine();
            guncellenecekKisi.TelefonNumarasi = yeniTelefon;
            Console.WriteLine("Kişinin numarası başarıyla güncellendi.");
        }

        public void RehberListele(char siralamaYonu)
        {
            List<RehberKayit> siraliRehber;
            if (siralamaYonu == 'A' || siralamaYonu == 'a')
            {
                siraliRehber = rehber.OrderBy(kisi => kisi.Isim).ToList();
            }
            else if (siralamaYonu == 'Z' || siralamaYonu == 'z')
            {
                siraliRehber = rehber.OrderByDescending(kisi => kisi.Isim).ToList();
            }
            else
            {
                Console.WriteLine("Geçersiz sıralama yönü girdiniz. Lütfen 'A' veya 'Z' girin.");
                return;
            }

            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var kisi in siraliRehber)
            {
                Console.WriteLine($"İsim: {kisi.Isim}, Soyisim: {kisi.Soyisim}, Telefon Numarası: {kisi.TelefonNumarasi}");
            }
        }

        public void RehberArama(int aramaTipi)
        {
            if (aramaTipi == 1)
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin adını veya soyadını giriniz:");
                string arananKelime = Console.ReadLine();
                List<RehberKayit> bulunanKisiler = rehber.FindAll(kisi => kisi.Isim.Contains(arananKelime) || kisi.Soyisim.Contains(arananKelime));
                if (bulunanKisiler.Count == 0)
                {
                    Console.WriteLine("Aranan kriterlere uygun kişi bulunamadı.");
                    return;
                }

                Console.WriteLine("Arama Sonuçları:");
                Console.WriteLine("**********************************************");
                foreach (var kisi in bulunanKisiler)
                {
                    Console.WriteLine($"İsim: {kisi.Isim}, Soyisim: {kisi.Soyisim}, Telefon Numarası: {kisi.TelefonNumarasi}");
                }
            }
            else if (aramaTipi == 2)
            {
                Console.WriteLine("Lütfen aramak istediğiniz telefon numarasını giriniz:");
                string arananTelefon = Console.ReadLine();
                RehberKayit bulunanKisi = rehber.Find(kisi => kisi.TelefonNumarasi.Equals(arananTelefon));
                if (bulunanKisi == null)
                {
                    Console.WriteLine("Aranan telefon numarasına uygun kişi bulunamadı.");
                    return;
                }

                Console.WriteLine("Arama Sonuçları:");
                Console.WriteLine("**********************************************");
                Console.WriteLine($"İsim: {bulunanKisi.Isim}, Soyisim: {bulunanKisi.Soyisim}, Telefon Numarası: {bulunanKisi.TelefonNumarasi}");
            }
            else
            {
                Console.WriteLine("Geçersiz arama tipi seçtiniz. Lütfen '1' veya '2' girin.");
            }
        }
    }
}
