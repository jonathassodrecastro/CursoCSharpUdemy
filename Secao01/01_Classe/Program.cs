﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Jonathas Sodré Castro";
            pessoa.Sexo = "Masculino";
            pessoa.DataNascimento = new DateTime(1996, 7, 5);

            string texto = pessoa.ResumoPessoa();

            Console.WriteLine(texto);

            Console.ReadKey();
        }
    }
}