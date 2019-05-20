using System;
using System.Collections.Generic;

namespace AD2_Test3_Serge_Fabre
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TestHuisdier();

            Console.ReadKey();
            Console.WriteLine();

            TestInwoner();

            Console.ReadKey();
            Console.WriteLine();

            TestBelastingen();

            Console.ReadKey();
        }

        public static void TestHuisdier()
        {
            Hond Blacky = new Hond("Blacky", 3);
            Kip Tok = new Kip("Tok");
            Vis Dorry = new Vis("Dorry", 2);

            Console.WriteLine(Blacky);
            Console.WriteLine(Tok);
            Console.WriteLine(Dorry);
                       
        }

        public static void TestInwoner()
        {
            Inwoner Billy = new Inwoner("Billy", new Adres("Langestraat", 2));
            Inwoner Jane = new Inwoner("Jane", "Kortestraat", 20);

            Hond Pip = new Hond("Pip", 4);
            Billy.lstHuisdieren.Add(Pip);

            Hond Rex = new Hond("Rex", 4);
            Kip Poel = new Kip("Poel");
            Jane.lstHuisdieren.Add(Rex);
            Jane.lstHuisdieren.Add(Poel);

            Console.WriteLine(Billy);
            Console.WriteLine(Jane);

            
        }

        public static void TestBelastingen()
        {
            List<Inwoner> lstInwoners = new List<Inwoner>();

            Inwoner Billy = new Inwoner("Billy", new Adres("Langestraat", 2));
            Inwoner Jane = new Inwoner("Jane", "Kortestraat", 20);
            Inwoner Joe = new Inwoner("Joe", new Adres("Zandstraat", 50));
            lstInwoners.Add(Billy);
            lstInwoners.Add(Jane);
            lstInwoners.Add(Joe);
                        
            Hond Pip = new Hond("Pip", 4);
            Billy.lstHuisdieren.Add(Pip);

            Hond Rex = new Hond("Rex", 4);
            Kip Poel = new Kip("Poel");
            Kip Rocky = new Kip("Rocky");
            Jane.lstHuisdieren.Add(Rex);
            Jane.lstHuisdieren.Add(Poel);
            Jane.lstHuisdieren.Add(Rocky);


            int basis = 0;
            int extra = 0;
            foreach (Inwoner inwoner in lstInwoners)
            {
                 basis += inwoner.AantalHuisdieren * 5;
                 extra += inwoner.BerekenAantalHuisdierPoten();
            }

            int belastingTotaal = basis + extra;

            Console.WriteLine($"Totaal van alle belastingen voor alle inwoners met hun huisdieren is {belastingTotaal} euro.");

            basis = 0;
            extra = 0;
            foreach (Inwoner inwoner in lstInwoners)
            {
                if (inwoner.Adres.Straatnaam == "Kortestraat")
                {
                    basis += inwoner.AantalHuisdieren * 5;
                    extra += inwoner.BerekenAantalHuisdierPoten();
                }
                
            }
            int belastingTotaalStraat = basis + extra;

            Console.WriteLine($"Het totaal van de belastingen voor de Kortestraat bedraagt {belastingTotaalStraat} euro.");

            basis = 0;
            extra = 0;
            foreach (Inwoner inwoner in lstInwoners)
            {
                foreach (Huisdier huisdier in inwoner.lstHuisdieren)
                {
                    if (huisdier is Hond)
                    {
                        basis += 5;
                        extra += 4;
                    }
                }
                

            }
            int belastingTotaalDier = basis + extra;

            Console.WriteLine($"Totale belastingen voor alle honden bedraagt {belastingTotaalDier} euro.");

        }
    }
}
