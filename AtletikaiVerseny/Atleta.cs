﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtletikaiVerseny
{
    class Atleta
    {
        public string Rajtszam { get; private set; }

        public string VezNev { get; private set; }

        public string KerNev { get; private set; }

        public string Egyesulet { get; private set; }

        public int Ugras { get; private set; }




        public Atleta(string szoveg)
        {
            string[] adat = szoveg.Split(';');
            
            Rajtszam = adat[0];
            VezNev = adat[1];
            Egyesulet = adat[2];
            Ugras = int.Parse(adat[3]);
            
        }







    }
}
