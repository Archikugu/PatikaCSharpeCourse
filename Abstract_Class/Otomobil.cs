using static Abstract_Class.Sabitler;

namespace Abstract_Class
{
    public abstract class Otomobil
    {
        public int kacTekerlektenOlusur()
        { return 4; }

        /*public virtual Renk StandartRengiNe()
        {return Renk.Beyaz;}*/
        public abstract Renk StandartRengiNe();

        public abstract Marka HangiMarkaninAraci();
    }
}
