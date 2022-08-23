using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class ClasseInternaPessoa
    {
        void GetOlhos()
        {
            //instanciando a classe olho dentro da classe pessoa
            Olho olho = new Olho();
        }
        
        //com o modificador public a classe olho passa a ser acessível pelo programa
        public class Olho
        {
            //classe interna criada com a mesma sintaxe mas dentro de uma classe
            //a classe olho só é acessível pela classe pessoa
            
            //instanciando pessoa dentro de olho
            public Olho()
            {
                ClasseInternaPessoa pessoa = new ClasseInternaPessoa();
            }
           
            public static string Iris = "Castanho";

           
        }
    }
}
