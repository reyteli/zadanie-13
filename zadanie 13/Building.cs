using System;

namespace zadanie_13
{
    class Building
    {
        
            string adres;
            double dlina;
            double shirina;
            double visota;


        double Dlina
        {
            get
            {
                return dlina;
            }
            set
            {
                if (value > 500)
                    dlina = 500;
                else if (value < 100)
                    dlina = 100;
                else
                    dlina = value;
            }
        }
        double Shirina
        {
            get
            {
                return shirina;
            }
            set
            {
                if (value > 500)
                    shirina = 500;
                else if (value < 100)
                    shirina = 100;
                else
                    shirina = value;
            }
        }
        double Visota
        {
            get
            {
                return visota;
            }
            set
            {
                if (value > 500)
                    visota = 500;
                else if (value < 100)
                    visota = 100;
                else
                    visota = value;
            }
        }
        public Building(string adres, double dlina, double shirina, double visota)
        {
            this.adres = adres;
            this.Dlina = dlina;
            this.Shirina = shirina;
            this.Visota = visota;

        }
        public string Print()
        {
            return $"{adres} {dlina} {shirina} {visota}";
        }


    }
}
