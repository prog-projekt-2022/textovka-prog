using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textovka_prog
{
     internal class Setkani
    {
        static Random rng = new Random();
        //setkani default

        public static string ZkuseniVstupu(string vstup)
        {
            try
            {
                if (vstup == null)
                {
                    Console.WriteLine("Špatný vstup!");
                    return "spatny";
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

        //setkani
        public static void PrvniSetkani()                                   //metoda prvni setkání (jenom pro napsání storylinu)
        {
            Console.WriteLine("storyline pro prvni setkani");
            Console.ReadKey();
            Souboj(false, "Neznámý nepřítel",1 ,4);
        }
        public static void ZakladniSouboj(string informace)
        {
            Console.Clear(); 
            Console.WriteLine(informace);
            Console.ReadKey();
            Souboj(true, "", 0, 0);
        }
        public static void ZakladniSouboj()
        {
            Console.Clear();
            Console.WriteLine("Z ničeho nic se před tebou něco objeví, ještě před tím než stihneš zareagovat zaútočí to, podaří se ti obránit.");
            Console.ReadKey();
            Souboj(true, "", 0, 0);
        }
        public static void NahodnySouboj()
        {
            switch (rng.Next(0, 1))
            {
                case 0:
                    Souboj(true, "",0 , 0);
                    break;
                case 1:
                    KouzelnikSouboj();
                    break;
            }
        }
        public static void KouzelnikSouboj()
        {
            Console.Clear();
            Console.WriteLine("");
            Souboj(false, "The Kouzelnik", 4, 4);
        }
        //nastroje stekani
        public static void Souboj(bool random, string jmeno, int sila, int zdravi) //základní metoda pro fighting systém
        {
            string jm = "";
            int si = 0;
            int zd = 0;
            if (random)
            {
                jm = DostanJmeno();
                si = Program.aktualniHrac.DostanSilu();
                zd = Program.aktualniHrac.DostanZdravi();
            }

            else
            {
                jm = jmeno;
                si = sila;
                zd = zdravi;
            }

            while (zd > 0)
            {
                Console.Clear();
                Console.WriteLine(jm);
                Console.WriteLine(si + "/"+ zd);
                Console.WriteLine("====================");                  //text-based gui které se ukazuje během souboje
                Console.WriteLine("| (U)tok (B)ranit  |");
                Console.WriteLine("| (R)Utek (L)ektvar|");
                Console.WriteLine("====================");
                Console.WriteLine("Potions:"+Program.aktualniHrac.lektvary+" Zdravi: "+Program.aktualniHrac.zdravi); //vypsání hodnot inventáře hráče

                string vybranaAkce = ZkuseniVstupu(Console.ReadLine());
                if (vybranaAkce != "spatny")
                {
                    if (vybranaAkce.ToLower() == "u" || vybranaAkce.ToLower() == "utok" || vybranaAkce.ToLower() == "útok")
                    {
                        //utok
                        Console.WriteLine("text utoku");
                        int poskozeni = si - Program.aktualniHrac.hodnotabrneni;
                        int utok = rng.Next(1, Program.aktualniHrac.hodnotazbrane) + rng.Next(1, 4);
                        Console.WriteLine("Ztratil jsi " +poskozeni + " zdraví a udělil jsi " + utok +" poškození.");
                        zd -= utok;
                        if (utok > zd)
                        {
                            int penize = Program.aktualniHrac.DostanPenize();
                            Console.WriteLine("Po zneškodnění " + jm + " dostáváš " + penize + " zlaťáků.");
                            Program.aktualniHrac.penize += penize;
                            Console.ReadKey();
                        }
                    }

                    else if (vybranaAkce.ToLower() == "b" || vybranaAkce.ToLower() == "branit" || vybranaAkce.ToLower() == "bránit")
                    {
                        //branit
                        Console.WriteLine("text obrany");
                        int poskozeni = (si / 4) - Program.aktualniHrac.hodnotabrneni;
                        if (poskozeni < 0)
                        {
                            poskozeni = 0;
                        }
                        int utok = rng.Next(1, Program.aktualniHrac.hodnotazbrane) / 2;
                        Console.WriteLine("Ztrácíš " + poskozeni + " zdraví a udělil jsi " + utok + " poškození.");
                        zd -= utok;
                        if (utok > zd)
                        {
                            int penize = Program.aktualniHrac.DostanPenize();
                            Console.WriteLine("Po zneškodnění " + jm + " dostáváš " + penize + " zlaťáků.");
                            Program.aktualniHrac.penize += penize;
                            Console.ReadKey();
                        }
                    }

                    else if (vybranaAkce.ToLower() == "r" || vybranaAkce.ToLower() == "utek" || vybranaAkce.ToLower() == "útěk")
                    {
                        //utek
                        if (rng.Next(0, 2) == 0)
                        {
                            Console.WriteLine("Napodařilo se ti utéct.");
                            int poskozeni = si - Program.aktualniHrac.hodnotabrneni;
                            if (poskozeni < 0)
                            {
                                poskozeni = 0;
                            }
                            Console.WriteLine("Dostáváš" + poskozeni + " poškození.");
                        }
                        else
                        {
                            Console.WriteLine("Utekl jsi" + jmeno + " ,po cestě ses rozhodl v obchodě dopnit zásoby.");
                            Console.ReadKey();
                            Obchod.NacistObchod(Program.aktualniHrac);
                        }
                    }

                    else if (vybranaAkce.ToLower() == "l" || vybranaAkce.ToLower() == "lektvar")
                    {
                        //lektvar
                        if (Program.aktualniHrac.lektvary == 0)
                        {
                            Console.WriteLine("Nemáš žádné lektvary!");
                            int poskozeni = si - Program.aktualniHrac.hodnotabrneni;
                            if (poskozeni > 0)
                            {
                                poskozeni = 0;
                            }
                            Console.WriteLine(jm+" tě udeří a ztratíš "+poskozeni+" zdraví!");
                        }
                        else
                        {
                            Console.WriteLine("Úspěšně vypiješ lektvar.");
                            int lektvarV = 5;
                            Console.WriteLine("Regeneruješ"+lektvarV+"zdraví!");
                            Program.aktualniHrac.zdravi += lektvarV;
                            Console.WriteLine("Mezi tím co jsi pil lektvar protivník zaútočil.");
                            int poskozeni = (si / 2) - Program.aktualniHrac.hodnotabrneni;
                            if (poskozeni < 0)
                            {
                                poskozeni = 0;
                            }
                            Console.WriteLine("Ztrácíš " + poskozeni + " zdraví");
                        }
                        Console.ReadKey();
                    }
                    if (Program.aktualniHrac.zdravi <= 0)
                    {
                        Console.WriteLine("You died.");
                        Console.ReadKey();
                        Console.WriteLine("Zabil tě "+ jm +" .");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                    Console.ReadKey();
                    Console.Clear();        //každý cyklus se vymaže terminál
                }

            }
        }
        public static string DostanJmeno()
        {
            switch (rng.Next(0, 12))
            {
                case 0:
                    return "Kostivec";
                case 1:
                    return "Přerostlá šublera";  
                case 2:
                    return "Velká houba";
                case 3:
                    return "Entita "+ rng.Next(0, 9999);
                case 4:
                    {
                        if (rng.Next(0, 999) == 727)
                        {
                            return "Tvoje máma";
                        }
                        else 
                        {
                            return "Modrý Balvan";
                        }
                    }
                 case 5:
                    return "Slime";
                 case 6:
                    return "Steve";
                 case 7:
                    return "Tobiáš";
                 case 8:
                    return "Gargamel";
                 case 9:
                    return "BaBajay";
                 case 10:
                    return "Shroud";
                 case 11:
                    {
                        if (rng.Next(0, 999) == 666)
                        {
                            return "Ninja with ligma";
                        }
                        else
                        {
                            return "Ninja";
                        }
                    }
                 case 12:
                    return "MrBeast";

            }
            return "Shrek";
        }
    }
}
