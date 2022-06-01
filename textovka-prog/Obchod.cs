using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textovka_prog
{
    internal class Obchod
    {
        static int brnenimod;
        static int zbranmod;
        static int difmod;

        public static void NacistObchod()
        {
            Console.WriteLine("Lamp Oil? Rope? Bombs? You want it? It's yours my friend, as long as you have enough Penize!");
            Console.WriteLine("Máš " + Program.aktualniHrac.penize + " peněz");
            SpustitObchod();
        }

        public static void SpustitObchod()
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

            string input = Console.ReadLine().snizit());



            if (input == "p" || Console.ReadLine().lektvar())
            {

            }
            else if (input == "z" || Console.ReadLine().zbran())
            {

            }
            else (input == "o" || Console.ReadLine().obrana())
            {

            }

        }
        static void ZkusitKoupit(string vec, int cena, Hrac p)
        {
            if (Program.aktualniHrac.penize >= cena)
            {
                if (!Program.aktualniHrac.vec == "lektvar")
                    Program.aktualniHrac.lektvary++;
                Console.WriteLine("Koupil sis Lektvar a byl přidán do tvého inventáře.");
            }

            if (Program.aktualniHrac.penize >= cena)
            {
                if (!Program.aktualniHrac.vec == "zbran")
                    Program.aktualniHrac.hodnotazbrane++;
                Console.WriteLine("Koupil sis Zbraň a byla přidána do tvého invenáře.");
            }

            if (Program.aktualniHrac.penize >= cena)
            {
                if (!Program.aktualniHrac.vec == "obrana")
                    Program.aktualniHrac.hodnotabrneni++;
                Console.WriteLine("Koupil sis Brněna a bylo přidáno do tvého inventáře.");
            }

            else
            {
                Console.WriteLine("Sorry " +Program.aktualniHrac.jmeno + ",");
                Console.ReadKey();
                Console.WriteLine("I can't give credit.");
                Console.ReadKey();
                Console.WriteLine("Come back when you're a little mmmmmmmmmmmmmmmm richer!");
            }
            Program.aktualniHrac.penize -= cena;
        }






    }
}
