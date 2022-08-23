using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classe
{
    class Pessoa
    {
        public string Nome;
        public string Sexo;
        public DateTime DataNascimento;
        
        public string ResumoPessoa()
        {
            string resumo = "Nome: " + Nome;
            resumo += "\nSexo: " + Sexo;
            resumo += "\nData de Nascimento: " + DataNascimento;
            return resumo;
        }
    }
}
