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
            Souboj(false, "Neznámý nepřítel",1 ,4);
        }

        //nastroje stekani
        public static void Souboj(bool random, string jmeno, int si, int zd)
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
                Console.WriteLine(jm);
                Console.WriteLine(si + "/"+ zd);
                Console.WriteLine("====================");
                Console.WriteLine("| (U)tok (B)ranit |");
                Console.WriteLine("| (R)Utek (L)ektvar|");
                Console.WriteLine("====================");
                Console.WriteLine("Potions:"+Program.aktualniHrac.lektvary+" Zdravi: "+Program.aktualniHrac.zd);
                string vybranaakce = Console.ReadLine();
                if(vybranaakce.ToLower() == "u" || input.ToLower() == "utok" || input.ToLower() == "útok")
                {
                    //utok
                    Console.WriteLine("text utoku");
                    int poskozeni = si - Program.aktualniHrac.hodnotabrneni;
                    int utok = rand.Next(1, Program.aktualniHrac.hodnotazbrane) + rand.Next(1, 4);
                    Console.WriteLine("text vysledku");
                    zd -= utok;
                }

                else if(vybranaakce.ToLower() == "b" || input.ToLower() == "branit" || input.ToLower() == "bránit")
                {
                    //branit
                    Console.WriteLine("text obrany");
                    int poskozeni = (si / 4) - Program.aktualniHrac.hodnotabrneni;
                    if(poskozeni < 0)
                    {
                        poskozeni = 0;
                    }
                    int utok = rand.Next(1, Program.aktualniHrac.hodnotazbrane) / 2;
                    Console.WriteLine("text vysledku");
                    zd -= utok;
                }

                else if(vybranaakce.ToLower() == "r" || input.ToLower() == "utek" || input.ToLower() == "útěk")
                {
                    //utek
                    if(rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("text uteku");
                        int poskozeni = si - Program.aktualniHrac.hodnotabrneni;
                        if(poskozeni < 0)
                        {
                            poskozeni = 0;
                        }
                        Console.WriteLine("text spatneho vysledku");
                    }
                    else
                    {
                        Console.WriteLine("text dobreho vysledku");
                        Console.ReadKey();
                    }
                }

                else if(vybranaakce.ToLower() == "l" || input.ToLower() == "lektvar")
                {
                    //lektvar
                    if(Program.aktualniHrac.lektvar == 0)
                    {
                        Console.WriteLine("Nemáš žádné lektvary!");
                        int poskozeni = si - Program.aktualniHrac.hodnotabrneni;
                        if(poskozeni > 0)
                        {
                            poskozeni = 0;
                        }
                        Console.WriteLine(jmeno+"tě udeří a ztratíš"+poskozeni+"zdraví!");
                    }
                    else
                    {
                        Console.WriteLine("Úspěšně vypiješ lektvar.");
                        int lektvarV = 5;
                        Console.WriteLine("Regeneruješ"+lektvarV+"zdraví!");   
                        Program.aktualniHrac.zd += lektvarV;
                    }
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
