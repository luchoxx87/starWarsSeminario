using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioWars
{
    class SableLaser : IArma
    {
        public int poderPara(Soldado soldado)
        {
            return soldado.poderTotal() * 10;
        }
    }
}
