using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PassagemParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 25;
            Console.WriteLine("Main > var valor: " + valor);

            AlterarValor(valor);
            Console.WriteLine("Main > var valor: " + valor);

            AlterarValorPorRef(ref valor);
            Console.WriteLine("Main > var valor: " + valor);

            AlterarValorOut(out valor);
            Console.WriteLine("Main > var valor: " + valor);

            VariasEntradas01("Elias", "Jose", "Maria");

            string[] nomes = {"Elias", "Jose", "Maria", "Filipe"};
            VariasEntradas02(nomes);

            VariasEntradas03("Elias", "Jose", "Maria", "Filipe", "Jesus", "Jonathas");


            Console.ReadKey();
        }
        static void VariasEntradas01(string nome1, string nome2, string nome3)
        {
            string[] nomes = { nome1, nome2, nome3 };
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.WriteLine();
        }
        static void VariasEntradas02(string[] nomes)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.WriteLine();
        }
        static void VariasEntradas03(params string[] nomes)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.WriteLine();
        }
        static void AlterarValor(double valor)
        { 
            Console.WriteLine("AlterarValor > var valor: " + valor);

            valor += 10;

            Console.WriteLine("AlterarValor > var valor: " + valor);
        }

        static void AlterarValorPorRef (ref double valor)
        {
            Console.WriteLine("AlterarValorPorRef > var valor: " + valor);

            valor += 15;

            Console.WriteLine("AlterarValorPorRef > var valor: " + valor);
        }

        static void AlterarValorOut(out double valor) 
        {

            valor = 15;

            Console.WriteLine("AlterarValorOut > var valor: " + valor);
        }

        


    }
}
