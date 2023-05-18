using OrientaaoAObjetos.Dia1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel Felipe";
            p1.Idade = 210;
            p1.Mensalidade = 15.78m;
            p1.Socio = true;
            p1.Interesses = "Conhecer novos modelos.";

            Console.WriteLine($"Nosso grande cliente:{p1.Nome.ToUpper()}");
            Console.WriteLine(p1.VerificarSociedade()?"é nosso sócio" : "não é sócio");
            Console.ReadKey();

        }
    }
}
