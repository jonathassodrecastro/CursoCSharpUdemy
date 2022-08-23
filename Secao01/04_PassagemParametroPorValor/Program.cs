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

            Console.ReadKey();
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
