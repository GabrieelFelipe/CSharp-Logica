using System;
using System.Security.Permissions;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





using System;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            string usuarioPadrao = "João";
            string senhaPadrao = "123";
            int tentativas = 0;
            string usuario;
            string senha;

            Console.WriteLine("Bem-vindo(a) ao sistema de login!");

            // Repetição de autenticação
            while (tentativas < 3)
            {
                Console.WriteLine("Digite seu usuário: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine();

                if (usuario == usuarioPadrao && senha == senhaPadrao)
                {
                    Console.WriteLine("Login realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");
                    tentativas++;
                    if (tentativas == 3)
                    Console.WriteLine("Tentativas excedidas! Volte novamente mais tarde! ");
                }
            }

            // Negativação de login
            Console.WriteLine("Número máximo de tentativas excedido. Tente novamente mais tarde.");
            
                              
            
        }
    }
}






