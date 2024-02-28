using static Abstract_Class.Sabitler;

namespace Abstract_Class
{
    public class NewFocus : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}
