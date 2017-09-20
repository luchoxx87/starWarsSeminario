using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioWars
{
    class Jedi : Soldado
    {
        int midiclorianos;

        public Jedi(int unosMidiclorianos, string unNombre, int unaVida) 
            : base (unNombre, unaVida)
        {
            midiclorianos = unosMidiclorianos;
        }

        public override int poderTotal()
        {
            return base.poderTotal() + midiclorianos; 
        }

        public override string ToString()
        {
            return base.ToString() + midiclorianos.ToString() + " midiclorianos";
        }
    }
}
