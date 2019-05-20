using System;
using System.Collections.Generic;
using System.Text;

namespace AD2_Test3_Serge_Fabre
{
    class Adres
    {
        public string Straatnaam { get; set; }
        public int Huisnummer { get; set; }

        public Adres(string strnaam, int hsnummer)
        {
            Straatnaam = strnaam;
            Huisnummer = hsnummer;
        }

        public override string ToString()
        {
            return $"{Straatnaam} {Huisnummer}";
        }
    }
}
