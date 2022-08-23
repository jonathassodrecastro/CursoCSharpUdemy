using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace ProjetoCurso.Conversores
{
    class FuncionarioTexto
    {
        public static string ConverterParaTexto(Funcionario funcionario)
        {
            String texto = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}",
                funcionario.Nome,
                funcionario.DataNascimento,
                funcionario.Telefone,
                funcionario.CPF,
                funcionario.RG,
                funcionario.CEP,
                funcionario.Estado,
                funcionario.Cidade,
                funcionario.Endereco,
                funcionario.Cargo,
                funcionario.Salario,
                funcionario.DataAdmissao
                );
            return texto;
        }

        public static Funcionario ConverterParaFuncionario(String Linha)
        {
            string[] elementos = Linha.Split(',');

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = elementos[0];
            funcionario.DataNascimento = DateTime.Parse(elementos[1]);
            funcionario.Telefone = elementos[2];
            funcionario.CPF = elementos[3];
            funcionario.RG = elementos[4];
            funcionario.CEP = int.Parse(elementos[5]);
            funcionario.Estado = elementos[6];
            funcionario.Cidade = elementos[7];
            funcionario.Endereco = elementos[8];
            funcionario.Cargo = elementos[9];
            funcionario.Salario = double.Parse(elementos[10]);
            funcionario.DataAdmissao = DateTime.Parse(elementos[11]);

            return funcionario;
        }
    }
}
