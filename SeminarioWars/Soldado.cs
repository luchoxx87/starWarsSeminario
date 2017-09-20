using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioWars
{
    class Soldado
    {
        string nombre;
        int vida;
        List<IArma> armas; 

        public int poderTotal()
        {
            return armas.Sum(cadaArma => cadaArma.poderPara(this));
        }


    }
}
