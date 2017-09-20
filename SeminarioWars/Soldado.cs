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

        public Soldado(string unNombre, int unaVida)
        {
            nombre = unNombre;
            vida = unaVida;
            armas = new List<IArma>();
        }
        public virtual int poderTotal()
        {
            return armas.Sum(cadaArma => cadaArma.poderPara(this));
        }

        public void agregarArma(IArma unArma)
        {
            armas.Add(unArma);
        }

        public override string ToString()
        {
            return string.Format("{0}\tvida{1}", nombre, vida);
        }
    }
}
