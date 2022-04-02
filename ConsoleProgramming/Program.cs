using System;

namespace ConsoleProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main ana fonksiyon default olarak public tir
            //static bir nesne örneği yaratmadan maine ulaşma
            //void geri dönmeyecek
            Console.WriteLine("Hello World");
            Console.WriteLine("İsminizi giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz");
            string lastname = Console.ReadLine();

            Console.WriteLine("Merhaba : " + name + " " + lastname);
        }
    }
}
