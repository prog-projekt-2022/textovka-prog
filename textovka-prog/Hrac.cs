using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textovka_prog
{
    [Serializable]
    internal class Hrac
    {
        Random rng = new Random();

        public string jmeno = "";
        public int id;
        public int penize = 30000;
        public int zdravi = 10;
        public int poskozeni = 1;
        public int hodnotabrneni = 1;
        public int lektvary = 5;
        public int hodnotazbrane = 1;

        public int modif = 0;

        public int DostanZdravi()
        {
            int horni = (modif +2);
            int dolni = (2 * modif + 5);
            return rng.Next(horni, dolni);
        }
        public int DostanSilu()
        {
            int horni = (modif +1);
            int dolni = (2 * modif + 1);
            return rng.Next(horni, dolni);
        }
        public int DostanPenize()
        {
            int horni = (15 * modif + 50);
            int dolni = (10* modif +10);
            return rng.Next(dolni, horni);
        }
    }
}
