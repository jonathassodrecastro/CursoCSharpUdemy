using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela.ManterCliente manterCliente = new Tela.ManterCliente();
            Tela.ManterFuncionario manterFuncionario = new Tela.ManterFuncionario();
            int opcoes = 0;

            try
            {

                while (opcoes != 5)
                {


                    Console.WriteLine("Selecione a opção abaixo:");
                    Console.WriteLine("1 - Cadastrar Cliente");
                    Console.WriteLine("2 - Listar Clientes");
                    Console.WriteLine("3 - Cadastrar Funcionário");
                    Console.WriteLine("4 - Listar Funcionários");
                    Console.WriteLine("5 - Sair");

                    opcoes = int.Parse(Console.ReadLine());

                    switch (opcoes)
                    {
                        case 1:
                            manterCliente.CadastrarCliente();
                            break;
                        case 2:
                            manterCliente.ListarClientes();
                            break;
                        case 3:
                            manterFuncionario.CadastrarFuncionario();
                            break;
                        case 4:
                            manterFuncionario.ListarFuncionarios();
                            break;
                        case 5:
                            Console.WriteLine("Obrigado.");
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            break;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Informar apenas números no menu!");
            }
       
        }
     }
 }
