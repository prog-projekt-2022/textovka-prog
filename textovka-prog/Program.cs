﻿namespace textovka_prog 
{
    class Program 
    {
        public static Hrac aktualniHrac = new Hrac();
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            Console.WriteLine("Nazev Hry");
            Console.WriteLine("Tvoje Jméno:");
            aktualniHrac.jmeno =Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nějaký storyline tady {0}", aktualniHrac.jmeno); //ve storylinu nejak pouzit jmeno zadane hracem
            if (aktualniHrac.jmeno == null)
            {
                Console.WriteLine("Ani nevíš své jméno....");
            }
            else
            {
                Console.WriteLine("Říkají ti: {0}", aktualniHrac.jmeno);
            }
        }
    }
}
