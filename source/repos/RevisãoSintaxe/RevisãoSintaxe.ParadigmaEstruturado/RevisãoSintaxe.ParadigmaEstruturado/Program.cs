using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisãoSintaxe.ParadigmaEstruturado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comemtário de uma linha

            /*
             * Comentário de múltiplas linhas
             */

            // variáveis v
            int idade = 43;
            float altura = 1.87f;
            decimal salario = 9000;
            double media = 6.78;

            // documentação ofiial dos tipos. onde buscar essas referências? no proprio google.
            // dica do prefesso: Estudar por tabelas é pode ser muito melhor.

            //Variavéis de referência
            string nome = "Gabriel Felipe Pereira dos Santos";
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            Console.WriteLine(nome);
            Console.WriteLine(nome.Substring(27));

            // Estrutura
            // Estrutura de Seleção (Condição)
            if (idade >= 42)
                Console.WriteLine("Super Jovem Jovem"); // sempre por chaves, pois isso é uma boa prática.

            if(idade <= 16)
            {
                Console.WriteLine("Hiper Jovem Jovem");
            }

            // Se aGeovana acertar na mega sena
            //Muito dinheiro --- Verdadeira
            //Senão
            //Vai ter que trabalhar --- Falso

            //Tipo de Inferência
            var vencedora = "Geovana";
            bool venceu = true;
            if (venceu)
            {
                Console.WriteLine("È muito Dinheiro! para a :"+vencedora);
            }
            else
            {
                Console.WriteLine(" Vai ter que trbalhar!");
            }

            //Switch (if compacto)
            var mes = 10;
            if(mes == 10)
            {
                Console.WriteLine("Janeiro");
            }else if (mes == 2)
            {
                Console.WriteLine("Fevereiro");
            }else if (mes == 3)
            {
                Console.WriteLine("Março");
            }else if (mes == 4)
            {
                Console.WriteLine("Abril");
            }else if (mes == 5)
            {
                Console.WriteLine("Maio");
            }else if (mes == 6)
            {
                Console.WriteLine("Junho");
            }else if (mes == 7)
            {
                Console.WriteLine("Julho");
            }else if (mes == 8)
            {
                Console.WriteLine("Agosto");
            }else if (mes == 9)
            {
                Console.WriteLine("Setembro");
            }else if (mes == 10)
            {
                Console.WriteLine("Outubro");
            }else if (mes == 11)
            {
                Console.WriteLine("Novembro");
            }else if (mes == 12)
            {
                Console.WriteLine("Dezembro");
            }else
            {
                Console.WriteLine("Não existe esse valor");
            }

            switch (mes)
            {
                case 1:Console.WriteLine("Janeiro");break;
                case 2:Console.WriteLine("Fevereiro");break;
                case 3:Console.WriteLine("Março");break;
                case 4:Console.WriteLine("Abril");break;
                case 5:Console.WriteLine("Maio");break;
                case 6:Console.WriteLine("Junho");break;
                case 7:Console.WriteLine("Julho");break;
                case 8:Console.WriteLine("Agoso");break;
                case 9:Console.WriteLine("Setembro");break;
                case 10:Console.WriteLine("Outubro");break;
                case 11:Console.WriteLine("Novembro");break;
                case 12:Console.WriteLine("Dezembro");break;
                default:Console.WriteLine("Dado Invaládo");break;

            }

            /* Estruturas------------------------------
             * 
             * while
             *            
             * do
             * 
             * for
             * 
             * Todas tem essa três coisas--------------
             * 
             * Inicio
             * 
             * Condição
             * 
             * Fim
             * 
             * Incremento e Decremento
             * 
             */
            int contador = 1; //Inicio

            while (contador <= 3) //Condição
            {
                Console.WriteLine("Leandro Fernandes");
                contador = contador + 1;
            }

            do
            {
                Console.WriteLine("Leandro Fernandes");
                contador = contador + 1;
            } while (contador <= 3);


            for (int i=1; i<=3; i=i+1)
            {
                Console.WriteLine("Daniel");
            }


            Console.ReadKey();




        }
    }
}
