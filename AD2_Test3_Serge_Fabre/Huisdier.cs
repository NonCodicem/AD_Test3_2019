using System;
using System.Collections.Generic;
using System.Text;

namespace AD2_Test3_Serge_Fabre
{
    abstract class Huisdier
    {
        public string Naam { get; set; }
        public int AantalPoten { get; set; }

        public Huisdier(string nm, int poten)
        {
            Naam = nm;
            

            if (this is Vis)
            {
                if (poten != 0)
                {
                    AantalPoten = 0;
                }

                
            }
            else
            {
                AantalPoten = poten;
            }
        }

        public Huisdier(string nm)
        {
            Naam = nm;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} {Naam} ({AantalPoten} poten)";
        }
    }
}
