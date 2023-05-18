using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia2
{

 // O construtor tem o mesmo nome da classe


    public class Segurado
    {

        
        
        //Construtor default (padrão)
            //O construtor tem o mesmo nome da classe
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        
        
        
        
        
        
        //Construtor vazio
        public Segurado() 
        {

        }
        
        
        
        
        
        
        //Construtor com parâmetro
            //Pesquisar por ID
        public Segurado(int id)
        {
            Id = id;
        }
        
        
        
        
        
        
        
        
        //Construtor com sobrecarga (Override [trad. sobrecarga])
            //Cadastrar - insert no banco
        public Segurado(string nome)
        {
            Nome = nome;
        }
        public Segurado(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }







        public string Teste()
        {
            return "Está funcionando! :D";
        }


    }

    
}
