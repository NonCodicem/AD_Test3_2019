using System;
using System.Collections.Generic;
using System.Text;

namespace AD2_Test3_Serge_Fabre
{
    class Inwoner
    {
        public string Naam { get; set; }
        public Adres Adres { get; set; }
        public List<Huisdier> lstHuisdieren { get; set; } = new List<Huisdier>();
        public int AantalHuisdieren {
            get { return lstHuisdieren.Count; }
        }

        public Inwoner(string naam, Adres adres)
        {
            Naam = naam;
            Adres = adres;
        }

        public Inwoner(string naam, string str, int nr)
        {

            Naam = naam;
            Adres = new Adres(str, nr);
            
            
        }

        public int BerekenAantalHuisdierPoten()
        {
            int aantal = 0;
            foreach (Huisdier item in lstHuisdieren)
            {
                aantal += item.AantalPoten;
            }

            return aantal; 
        }

        public override string ToString()
        {
            return $"{Naam} ({Adres}) heeft {AantalHuisdieren} huisdieren met in totaal {BerekenAantalHuisdierPoten()} poten";
        }
    }
}
