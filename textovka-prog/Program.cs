using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace textovka_prog
{
    class Program 
    {
        public static Hrac aktualniHrac = new Hrac();
        public static bool hlavniLoop = true;
        static void Main(string[] args)
        {
            if (!Directory.Exists("saves"))
            {
                Directory.CreateDirectory("saves");
            }

            Start();
            Setkani.PrvniSetkani();

            if (hlavniLoop == true)
            {
                Setkani.NahodnySouboj();
            }
            //Ulozit();
        }
        static void Start()
        {
            Console.WriteLine("Napiš tam název hry");
            Console.WriteLine("Napiš Tvoje Jméno:");
            aktualniHrac.jmeno = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nějaký storyline tady {0}", aktualniHrac.jmeno); //ve storylinu nejak pouzit jmeno zadane hracem
            if (aktualniHrac.jmeno == null)
            {
                Console.WriteLine("Ani nevíš své jméno....");
            }
            else
            {
                Console.WriteLine("Říkají ti {0}", aktualniHrac.jmeno);
            }
            Console.ReadKey();
            Console.Clear();
        }
        /*public static void Ulozit()
        {
            BinaryFormatter binForm = new BinaryFormatter();
            string cesta = "saves/" + aktualniHrac.id.ToString();
            FileStream soubor = File.Open(cesta, FileMode.OpenOrCreate);
            binForm.Serialize(soubor, aktualniHrac);
        }
        public static Hrac Nacist()
        {
            Console.Clear();
            string[] cesty = Directory.GetDirectories("saves");

            List<Hrac> hraci = new List<Hrac>();
            BinaryFormatter binForm = new BinaryFormatter();
            foreach (string c in cesty)
            {
                FileStream soubor = new FileStream(c, FileMode.Open);
                Hrac hrac = (Hrac)binForm.Deserialize(soubor);
                soubor.Close();
                hraci.Add(hrac);
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Vyber si vaši uloženou hru:");

                foreach (Hrac hrac in hraci)
                {
                    Console.WriteLine(hrac.id+"_"+hrac.jmeno);
                }
                Console.WriteLine("Prosím vložte jméno hráče nebo jeho ID. (v případě ID napište id:#)");

                string[] rawvstup = Console.ReadLine().Split(":");

                try
                {
                    if (rawvstup[0] == "id")
                    {
                        if (int.TryParse(rawvstup[1], out int id))
                        {
                            foreach (Hrac hrac in hraci)
                            {
                                if (hrac.id == id)
                                {
                                    return hrac;
                                }
                            }
                            Console.WriteLine("Soubor Neexistuje");
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("Vaše ID bylo zadáno špatně.");
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Vaše ID bylo zadáno špatně. (Pro pokračování zmáčkni jakoukoli klávesu.)");
                    Console.ReadKey();
                }
            }
        }*/
    }
}
