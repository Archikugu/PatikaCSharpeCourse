using System;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen Dikdortgen = new Dikdortgen();
            Dikdortgen.KisaKenar = 3;
            Dikdortgen.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı : {0}", Dikdortgen.AlanHesapla());

            //DikdortgenStruct Dikdortgen = new DikdortgenStruct();

            DikdortgenStruct DikdortgenStruck;
            DikdortgenStruck.UzunKenar = 3;
            DikdortgenStruck.KisaKenar = 4;

            Console.WriteLine("Struct Alan Hesabı : {0}", DikdortgenStruck.AlanHesapla());
           
            DikdortgenStructParam DikdortgenStructParam = new DikdortgenStructParam(3, 4);
            Console.WriteLine("Parametreli Struct Alan Hesabı : {0}", DikdortgenStructParam.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct DikdortgenStruct
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }

    }

    struct DikdortgenStructParam
    {

        public DikdortgenStructParam(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
