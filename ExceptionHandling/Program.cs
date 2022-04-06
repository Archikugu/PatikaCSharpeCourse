using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            //Compiler time && Run time 
            //Run time hataları yakalamak gerekir programı kırmaması niçin 
/*
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata"+ex.Message.ToString());             
            }
            finally //koşulsuz çalışşır
            {
                Console.WriteLine("işlem tamamlandı");
            }
*/

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("Test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok büyük yada çok büyük değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarı ile tamamlandı");
            }



        }
    }
}
