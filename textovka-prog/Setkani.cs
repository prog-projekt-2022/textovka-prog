using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textovka_prog
{
    internal class Setkani
    {
        //setkani default


        //setkani
        public static void PrvniSetkani()
        {
            Console.WriteLine("storyline pro prvni setkani");
        }

        //nastroje stekani
        public static void Souboj(bool random, string jmeno, int sila, int zdravi)
        {
            string jm = "";
            int si = 0;
            int zd = 0;
            if (random)
            {

            }
            else
            {
                jm = jmeno;
                si = sila;
                zd = zdravi;
            }
            while (zd > 0)
            {
                Console.WriteLine("====================");
                Console.WriteLine("| (U)Utok (B)ranit |");
                Console.WriteLine("| (R)Utek (L)ektvar|");
                Console.WriteLine("====================");
                Console.WriteLine("Potions:"+Program.aktualniHrac.lektvary+" Zdravi: "+Program.aktualniHrac.zdravi);
                string akce = Console.ReadLine();
            }
        }
    }
}
