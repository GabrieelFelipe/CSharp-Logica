using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia3
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }



        public Cliente()
        { }



        public Cliente(int id, string nome, string cPF)
        {
            Id = Id;
            Nome = nome;
            CPF = cPF;
        }



        public Cliente(string nome, string cPF)
        {
            Nome = nome;
            CPF = cPF;
        }



        public Cliente(int id)
        {
            Id = id;
        }


    }
}
