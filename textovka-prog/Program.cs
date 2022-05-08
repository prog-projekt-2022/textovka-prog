<<<<<<<<< Temporary merge branch 1
﻿// See https://aka.ms/new-console-template for more information
using textovka_prog;

TestovaciTrida Objekt = new TestovaciTrida(); 
Objekt.TestovaciMetodaTridy("hello there"); 


=========
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
>>>>>>>>> Temporary merge branch 2
