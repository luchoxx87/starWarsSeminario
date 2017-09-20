using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioWars
{
    class Blaster: IArma
    {
        int distancia;

        public Blaster(int unaDistancia)
        {
            distancia = unaDistancia;
        }
        public int poderPara(Soldado soldado)
        {
            return distancia;
        }
    }
}
