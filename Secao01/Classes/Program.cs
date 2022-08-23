using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //para instanciar Olho no Main eu preciso chamar a ClasseInternaPessoa
            new ClasseInternaPessoa.Olho();

            string iris = ClasseInternaPessoa.Olho.Iris;

            Console.ReadKey();
        }

    }
}

