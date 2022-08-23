using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Estruturas
{
    struct Polegada
    {
        double Centimetro;
        double polegada;

        public Polegada(double polegadas)
        {
            Centimetro = 2.54;
            polegada = Centimetro * polegadas;
        }

        public double GetPolegadaCentimetro() { return polegada; }
    }
}
