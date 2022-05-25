using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Obchod
    {
        

        public static void NacistObchod(Hrac p)
        {
            SpustitObchod(p);
        }

        public static void SpustitObchod(Hrac p)
        {
            int cenalektvaru = 50;
            int cenabrneni = 100;
            int cenazbrane = 100;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======Obchod=======");
                Console.WriteLine("|(L)ektvar (Z)bran|");
                Console.WriteLine("|    (O)brana     |");
                Console.WriteLine("====================");
                //pockej na odpoved
            }

            string input = Console.ReadLine().snizit();



            if (input == "p" || Console.ReadLine().lektvar();
            {


            }
            else if (input == "z" || Console.ReadLine().zbran();
            {


            }
            else if (input == "o" || Console.ReadLine().obrana();
            {


            }


        }
        static void ZkusitKoupit(string vec, int cena, Hrac p)
        {
            if (p.penize >= cena)
            {
                if (!p.vec == "lektvar")
                    p.lektvar++;
            }

            if (p.penize >= cena)
            {
                if (!p.vec == "zbran")
                    p.zbran++;
            }

            if (p.penize >= cena)
            {
                if (!p.vec == "obrana")
                    p.obrana++;
            }

            else
            {
                Console.WriteLine("Si moc chudy");
                Console.ReadKey();
            }
            p.penize -= cena;
        }






    }
}
