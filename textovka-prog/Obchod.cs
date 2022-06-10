using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textovka_prog
{
    internal class Obchod
    {

        public static string ZkuseniVstupu(string vstup)
        {
            try
            {
                if (vstup == null)
                {
                    Console.WriteLine("Špatný vstup!");
                }
                else
                {
                    return vstup;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Špatný vstup!");
            }
            return "spatny";
        }

        public static void NacistObchod(Hrac hrac)
        {
            Console.WriteLine("Lamp Oil? Rope? Bombs? You want it? It's yours my friend, as long as you have enough Penize!");
            Console.WriteLine("Máš " + Program.aktualniHrac.penize + " peněz");
            SpustitObchod(hrac);
        }

        public static void SpustitObchod(Hrac hrac)
        {
            int cenalektvaru;
            int cenabrneni;
            int cenazbrane;
            int cenaobtiznosthry;

            while (true)
            {

                cenalektvaru = 20 + 10 *hrac.modif;
                cenabrneni = 100 * hrac.hodnotabrneni;
                cenazbrane = 100 * hrac.hodnotazbrane;
                cenaobtiznosthry = 300 + 100 *hrac.modif;

                Console.Clear();
                Console.WriteLine("=======Obchod=======");
                Console.WriteLine("|(L)ektvar (Z)braň|");
                Console.WriteLine("|    (B)rnění     |");
                Console.WriteLine("| (M)btiznost hry |");
                Console.WriteLine("====================");
                Console.WriteLine("O(dejít)");
                Console.WriteLine("=======Staty=======");
                Console.WriteLine("|Sila zbreaně: "+ hrac.hodnotazbrane);
                Console.WriteLine("|Zdraví: "+ hrac.zdravi);
                Console.WriteLine("|Peníze: "+ hrac.penize);
                Console.WriteLine("|Odolnost brnění: "+ hrac.hodnotabrneni);
                Console.WriteLine("|Pocet lektvarů: "+ hrac.lektvary);
                Console.WriteLine("|Obtiznost hry: "+ hrac.modif);
                Console.WriteLine("====================");
                //pockej na odpoved

            string vstup = ZkuseniVstupu(Console.ReadLine().ToLower());
            if (vstup == "spatny")
            {
                Console.WriteLine("Špatný vstup.");
            }

            if (vstup == "l" || vstup == "lektvar")
            {
                ZkusitKoupit(0, cenalektvaru, hrac);
            }
            else if (vstup == "z" || vstup == "zbran" || vstup == "zbraň")
            {
                ZkusitKoupit(1, cenazbrane, hrac);
            }
            else if (vstup == "b" || vstup == "brneni"|| vstup == "brnění")
            {
                ZkusitKoupit(2, cenabrneni, hrac);
            }
            else if (vstup == "m" || vstup == "obtiznost"|| vstup == "obtiznost hry")
            {
                ZkusitKoupit(3, cenaobtiznosthry, hrac);
            }
            else if (vstup == "o" || vstup == "exit" || vstup =="odejít")
                break;
            }

        }
        static void ZkusitKoupit(int vec, int cena, Hrac hrac)
        {
            if (hrac.penize >= cena)
            {
                switch (vec)
                {
                    case 0:
                        hrac.lektvary++;
                        break;
                    case 1:
                        hrac.hodnotazbrane++;
                        break;
                    case 2:
                        hrac.hodnotabrneni++;
                        break;
                    case 3:
                        hrac.modif++;
                        break;
                }
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
