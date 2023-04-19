using System;
using System.Security.Permissions;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace VerduraoDoJoao.Melanciometro
{


    internal class Program
    {

        static void Main(string[] args)
        {
            string resp = "SIM";



            do

            {



                Console.WriteLine(" 1- Melancia Comum 2- Melancia baby");
                int op = int.Parse(Console.ReadLine());
                double preco, quatc, quatb, total;


                if (op == 1)
                {
                    preco = 5.50;
                    Console.WriteLine("Melancia Comum " + preco.ToString());
                    Console.WriteLine("Quantos kilos você deseja?");
                    quatc = int.Parse(Console.ReadLine());
                    quatc = preco * quatc;

                    Console.WriteLine($"valor total:{quatc}");
                }
                else if (op == 2)
                {
                    preco = 8.56;
                    Console.WriteLine("Melancia Baby " + preco.ToString());
                    Console.WriteLine("Quantos kilos você deseja?");
                    quatb = int.Parse(Console.ReadLine());
                    quatb = preco * quatb;

                    Console.WriteLine("valor total:" + quatb.ToString);
                }

                else

                {

                    Console.WriteLine("Digite 1 ");
                    Console.WriteLine("ou");
                    Console.WriteLine("Digite 2");

                }


                Console.WriteLine("Deseja sair? Sim ou não");
                Console.ReadLine();


            } while (resp != "SIM");



        }
    }
}
