using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.Arquivo;
using ProjetoCurso.Conversores;

namespace ProjetoCurso.Tela
{
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.Clear();

            Console.WriteLine("CADASTRAR FUNCIONARIO");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            funcionario.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            funcionario.CPF = Console.ReadLine();

            Console.Write("RG: ");
            funcionario.RG = Console.ReadLine();

            Console.Write("CEP(Digitar apenas números): ");
            funcionario.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            funcionario.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            funcionario.Cidade = Console.ReadLine();

            Console.Write("Endereço: ");
            funcionario.Endereco = Console.ReadLine();

            Console.Write("Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.Write("Data contratação: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            GerenciadorArquivo.GravarArquivo("funcionario", FuncionarioTexto.ConverterParaTexto(funcionario));
        }

        public void ListarFuncionarios()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE FUNCIONÁRIOS");

            string[] linhas = GerenciadorArquivo.LerArquivo("funcionario");

            foreach (string linha in linhas)
            {

                Funcionario cliente = Conversores.FuncionarioTexto.ConverterParaFuncionario(linha);
                Console.WriteLine("NOME: " + cliente.Nome + " CARGO: " + cliente.Cargo);

            }
        }
    }
}

