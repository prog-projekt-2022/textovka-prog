using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textovka_prog
{
    internal class Hrac
    {
        Random rand;

        public string jmeno = "";
        public int penize = 0;
        public int zdravi = 10;
        public int poskozeni = 1;
        public int hodnotabrneni = 1;
        public int lektvary = 5;
        public int hodnotazbrane = 1;

        public int mods = 0;

        public int DostanZdravi()
        {
            int horni = (2 * mods + 5);
            int dolni = (mods + 2);
            return rand.Next(horni, dolni);
        }
        public int DostanSilu()
        {
            int horni = (2 * mods + 1);
            int dolni = (mods +1);
            return rand.Next(horni, dolni);
        }
    }
}
