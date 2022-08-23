using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Metodos
{
    class Pessoa
    {
        public string Nome;
        public string Sexo;
        public DateTime DataNascimento;
        public double PosicaoX, PosicaoY;

        public string PegarPosicao()
        {
            return PosicaoX + ", " + PosicaoY;
        }

        public void SetPosicao(double x, double y)
        {
            PosicaoX = x; 
            PosicaoY = y;
        }
    }
}
