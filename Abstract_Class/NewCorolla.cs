using static Abstract_Class.Sabitler;

namespace Abstract_Class
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Siyah;
        }
    }
}
