﻿using static Abstract_Class.Sabitler;

namespace Abstract_Class
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Mavi;
        }
    }
}
