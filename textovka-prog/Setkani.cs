using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textovka_prog
{
    internal class Setkani
    {
        Random rand = new Random();
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
                Console.WriteLine("| (U)tok (B)ranit |");
                Console.WriteLine("| (R)Utek (L)ektvar|");
                Console.WriteLine("====================");
                Console.WriteLine("Potions:"+Program.aktualniHrac.lektvary+" Zdravi: "+Program.aktualniHrac.zdravi);
                string vybranaakce = Console.ReadLine();
                if(vybranaakce.ToLower() == "u" || input.ToLower() == "utok" || input.ToLower() == "útok")
                {
                    //utok
                    Console.WriteLine("text utoku");
                    int poskozeni = sila - Program.aktualniHrac.hodnotabrneni;
                    int utok = rand.Next(1, Program.aktualniHrac.hodnotazbrane) + rand.Next(1, 4);
                    Console.WriteLine("text vysledku");
                    zdravi -= utok;
                }
                else if(vybranaakce.ToLower() == "b" || input.ToLower() == "branit" || input.ToLower() == "bránit")
                {
                    //branit
                    Console.WriteLine("text obrany");
                    int poskozeni = (sila / 4) - Program.aktualniHrac.hodnotabrneni;
                    if(poskozeni < 0)
                    {
                        poskozeni = 0;
                    }
                    int utok = rand.Next(1, Program.aktualniHrac.hodnotazbrane) / 2;
                    Console.WriteLine("text vysledku");
                    zdravi -= utok;
                }
                else if(vybranaakce.ToLower() == "r" || input.ToLower() == "utek" || input.ToLower() == "útěk")
                {
                    //utek
                    if(rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("text uteku");
                        int poskozeni = sila - Program.aktualniHrac.hodnotabrneni;
                        if(poskozeni < 0)
                        {
                            poskozeni = 0;
                        }
                        Console.WriteLine("text spatneho vysledku");
                    }
                    else
                    {
                        Console.WriteLine("text dobreho vysledku");
                    }
                }
                else if(vybranaakce.ToLower() == "l" || input.ToLower() == "lektvar")
                {
                    //lektvar
                }
                else
                {
                    Console.WriteLine("Špatný vstup!");
                }
                Console.ReadKey();
            }
        }
    }
}
