using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public sealed class Funcionario : Pessoa
    {
        public int Matricula { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

    }
}
