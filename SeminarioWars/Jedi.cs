﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioWars
{
    class Jedi : Soldado
    {
        int midiclorianos;

        public override int poderTotal()
        {
            return base.poderTotal() + midiclorianos; 
        }

    }
}
