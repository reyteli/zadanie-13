using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_13
{
    sealed class MultiBuilding : Building
    {
        int etage;
        int Etage
        {
            get
            {
                return etage;
            }
            set
            {
                if (value > 80)
                    etage = 80;
                else if (value < 10)
                    etage = 10;
                else
                    etage = value;
            }
        }
        public MultiBuilding(string adres, double dlina, double shirina, double visota, int etage)
            : base(adres, dlina, shirina, visota)
        {
            this.Etage = etage;
        }
        public string Print()
        {
            string result = base.Print();
            result += $"  { etage }";
            return result;
        }
    }
}
