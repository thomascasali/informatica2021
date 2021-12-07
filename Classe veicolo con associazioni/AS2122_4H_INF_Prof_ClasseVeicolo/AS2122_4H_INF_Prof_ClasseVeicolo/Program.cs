using System;

namespace AS2122_4H_INF_Prof_ClasseVeicolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof; Lab 2.3 4H; 06/12/21; prova singola classe veicolo");

            string cruscotto = "";

            Veicolo v = new Veicolo("Ibrida", 1100, "pasticche", 17);

            // test veicolo si accende

            v.SportelloAperto(0, false);
            v.SportelloAperto(1, false);
            v.SportelloAperto(2, false);
            v.SportelloAperto(3, false);
            v.SportelloAperto(4, false);

            // pressione pneumatici : OK
            v.PressionePneumatico(0, 2);
            v.PressionePneumatico(1, 2);
            v.PressionePneumatico(2, 1.4);
            v.PressionePneumatico(3, 2);

            // usura freni : OK
            v.UsuraFreno(0, 10);
            v.UsuraFreno(1, 10);
            v.UsuraFreno(2, 10);
            v.UsuraFreno(3, 10);

            cruscotto = v.Accenditi();
            Console.WriteLine($"Cruscotto Accenditi :{cruscotto}");

            if (cruscotto == "OK")
                Console.WriteLine("Veicolo acceso.");
            else
                Console.WriteLine("*** Veicolo non acceso.");

            cruscotto = v.Muoviti();
            Console.WriteLine($"Cruscotto Muoviti :{cruscotto}");

            if (cruscotto == "OK")
                Console.WriteLine("Veicolo in movimento.");
            else
                Console.WriteLine("*** Veicolo non in movimento.");

            // pressione pneumatici : OK
            v.PressionePneumatico(0, 2);
            v.PressionePneumatico(1, 2);
            v.PressionePneumatico(2, 1.4);
            v.PressionePneumatico(3, 2);

            // usura freni : OK
            v.UsuraFreno(0, 10);
            v.UsuraFreno(1, 10);
            v.UsuraFreno(2, 10);
            v.UsuraFreno(3, 10);


            // test veicolo non si accende per gli sportelli 2 e 4 aperti

            v.SportelloAperto(0, false);
            v.SportelloAperto(1, false);
            v.SportelloAperto(2, true);
            v.SportelloAperto(3, false);
            v.SportelloAperto(4, true);

            cruscotto = v.Accenditi();
            Console.WriteLine($"Cruscotto Accenditi :{cruscotto}");

            if (cruscotto == "OK")
                Console.WriteLine("Veicolo acceso.");
            else
                Console.WriteLine("Veicolo non acceso.");

            Console.WriteLine("Il motore si deve accendere...");
            v.SportelloAperto(2, false);
            v.SportelloAperto(4, false);
            v.PressionePneumatico(2, 2);

            cruscotto = v.Accenditi();
            Console.WriteLine($"Cruscotto Accenditi :{cruscotto}");

            if (cruscotto == "OK")
                Console.WriteLine("Veicolo acceso.");
            else
                Console.WriteLine("Veicolo non acceso.");


            Console.WriteLine("Il veicolo non si deve muovere...");

            v.FrenoStazionamento(true);

            cruscotto = v.Muoviti();
            Console.WriteLine($"Cruscotto Muoviti :{cruscotto}");

            if (cruscotto == "OK")
                Console.WriteLine("Veicolo in movimento.");
            else
                Console.WriteLine("*** Veicolo non in movimento.");

            Console.WriteLine("Il veicolo si muove...");

            v.FrenoStazionamento(false);

            cruscotto = v.Muoviti();
            Console.WriteLine($"Cruscotto Muoviti :{cruscotto}");

            if (cruscotto == "OK")
                Console.WriteLine("Veicolo in movimento.");
            else
                Console.WriteLine("*** Veicolo non in movimento.");

        }
    }
}
