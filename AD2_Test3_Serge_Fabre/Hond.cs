using System;
using System.Collections.Generic;
using System.Text;

namespace AD2_Test3_Serge_Fabre
{
    class Hond : Huisdier
    {
        public int AantalPoten { get; set; }
        public Hond(string naam, int poten) : base(naam, poten)
        {
            
        }
    }
}
