using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Obchod
    {
        static int brnenimod;
        static int zbranmod;
        static int difmod;

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
            else (input == "o" || Console.ReadLine().obrana();
            {

            }

        }
        static void ZkusitKoupit(string vec, int cena, Hrac p)
        {
            if (p.penize >= cena)
            {
                if (!p.vec == "lektvar")
                    p.lektvar++;
                Console.WriteLine("Koupil sis Lektvar a byl přidán do tvého inventáře.");
            }

            if (p.penize >= cena)
            {
                if (!p.vec == "zbran")
                    p.zbran++;
                Console.WriteLine("Koupil sis Zbraň a byla přidána do tvého invenáře.");
            }

            if (p.penize >= cena)
            {
                if (!p.vec == "obrana")
                    p.obrana++;
                Console.WriteLine("Koupil sis Brněna a bylo přidáno do tvého inventáře.");
            }

            else
            {
                Console.WriteLine("Sorry" +aktualniHrac.jmeno + ",");
                Console.ReadKey();
                Console.WriteLine("I can't give credit.");
                Console.ReadKey();
                Console.WriteLine("Come back when you're a little mmmmmmmmmmmmmmmm richer!");
            }
            p.penize -= cena;
        }






    }
}
