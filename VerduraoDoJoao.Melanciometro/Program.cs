using System;
using System.Collections.Generic;


namespace VerduraoDoJoao.Melanciometro
{
    class Program
    {
        static List<string> caminhoes = new List<string>();
        static List<string> produtos = new List<string>();
        static Dictionary<string, string> usuarios = new Dictionary<string, string>();


        // Início - usuário
        static string usuario = "João";
        static string senha = "123";
        static int tentativas = 3;
        // Fim - usuário

        static void Main(string[] args)
        {

            //Início - Dias da semana
            string diaDaSemana = DateTime.Today.DayOfWeek.ToString();

            // Promoções do dia
            if (diaDaSemana == "Monday")
            {
                Console.WriteLine("Promoção de segunda!");
            }
            else if (diaDaSemana == "Tuesday")
            {
                Console.WriteLine("Terça verde!");
            }
            else if (diaDaSemana == "Wednesday")
            {
                Console.WriteLine("Quarta verde!");
            }
            else if (diaDaSemana == "Thursday")
            {
                Console.WriteLine("Promoção de quinta!");
            }
            else if (diaDaSemana == "Friday")
            {
                Console.WriteLine("Promoção de sexta!");
            }
            Console.WriteLine();
            //Fim - Dias da semana

            //Início - usuario, senha e tentativas
            bool autenticado = false;
            {


                Console.Write("Insira seu nome de usuário: ");
                string usuarioDigitado = Console.ReadLine();
                Console.Write("Insira sua senha: ");
                string senhaDigitada = Console.ReadLine();

                    while (usuarioDigitado != usuario || senhaDigitada != senha)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Cadastro não encontrado..");
                        Console.WriteLine();
                        tentativas--;
                        Console.WriteLine($"Usuário ou senha incorretos. [{tentativas}] tentativas restantes.");
                        Console.WriteLine();

                            if (tentativas == 0)
                            {
                                Console.WriteLine("Bloqueio por tentativas. Acesso negado!");
                                Console.ReadLine();
                                return;
                            }

                        Console.Write("Insira seu nome de usuário: ");
                        usuarioDigitado = Console.ReadLine();
                        Console.Write("Insira sua senha: ");
                        senhaDigitada = Console.ReadLine();
                    }

                    {
                        Console.WriteLine();
                        Console.WriteLine("Acesso liberado!");
                        Console.WriteLine();
                    }
            //Fim - usuario, senha e tentativas



                while (true)
                {
                    Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Console.WriteLine("█                                                             █");
                    Console.WriteLine("█                            Menu                             █");
                    Console.WriteLine("█                                                             █");
                    Console.WriteLine("█ Tecle 1 para: Registrar caminhão                            █");
                    Console.WriteLine("█ Tecle 2 para: Buscar caminhões por CPF/CNPJ do proprietário █");
                    Console.WriteLine("█ Tecle 3 para: Escolher melancias                            █");
                    Console.WriteLine("█ Tecle 4 para: Sair                                          █");
                    Console.WriteLine("█                                                             █");
                    Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");


                    Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();


                    switch (opcao)
                    {
                        case "1":
                            RegistrarCaminhao();
                            break;
                        case "2":
                            BuscarCaminhoesPorProprietario();
                            break;                      
                        case "3":
                            EscolherMelancias();
                            break;
                        case "4":
                            Sair();
                            Console.WriteLine("Pressione a tecla Enter para fechar o programa...");
                            Console.ReadKey();
                            return;
                        default:
                            Console.WriteLine("Escolha inválida!");
                            break;
                    }


                    Console.WriteLine();
                }
            }

        }


        static void EscolherMelancias()
        {


            double totalMelanciaComum = 0;
            double valorPorKgMelanciaComum = 5.50;
            double totalMelanciaBaby = 0;
            double valorPorKgMelanciaBaby = 8.54;


            // Dia atual
            DayOfWeek diaDaSemana = DateTime.Today.DayOfWeek;
            
            // Aplicaão de desconto do dia
            double desconto = 0;

            if (diaDaSemana == DayOfWeek.Tuesday)
            {
                desconto = 0.15;
            }
            else if (diaDaSemana == DayOfWeek.Wednesday)
            {
                desconto = 0.17;
            }
            else if (diaDaSemana == DayOfWeek.Monday)
            {
                desconto = 0.01;
            }
            else if (diaDaSemana == DayOfWeek.Thursday)
            {
                desconto = 0.02;
            }
            else if (diaDaSemana == DayOfWeek.Friday)
            {
                desconto = 0.03;
            }

            Console.WriteLine();

            if (desconto > 0)
            {
                
                Console.WriteLine($"Desconto diário de {desconto * 100}% aplicado na sua compra.");
                Console.WriteLine();
            }


            int opcao = 0;


            while (opcao < 1 || opcao > 3)
            {
                Console.Write("Qual melancia você deseja comprar: [ 1 - Melancia Comum | 2 - Melancia Baby | 3 - Ambas ]: ");
                int.TryParse(Console.ReadLine(), out opcao);

                    if (opcao < 1 || opcao > 3)
                    {
                        Console.WriteLine("Comando inválido. Digite um número entre 1 e 3.");
                    }
                    else
                    {
                        break;
                    }
            }


            double totalMelancia = 0;
            double valorPorKgMelancia = 0;


            if (opcao == 1)
            {
                valorPorKgMelancia = valorPorKgMelanciaComum;
                Console.Write("Digite a quantidade de melancia comum que deseja comprar: ");
                double.TryParse(Console.ReadLine(), out double quantidadeComum);
                totalMelancia = quantidadeComum * valorPorKgMelancia * (1 - desconto);
                Console.WriteLine($"Melancia comum | Quantidade: {quantidadeComum:F2} kg | Valor Total: R$ {totalMelancia:F2}");
            }
            else if (opcao == 2)
            {
                valorPorKgMelancia = valorPorKgMelanciaBaby;
                Console.Write("Digite a quantidade de melancia baby que deseja comprar: ");
                double.TryParse(Console.ReadLine(), out double quantidadeBaby);
                totalMelancia = quantidadeBaby * valorPorKgMelancia * (1 - desconto);
                Console.WriteLine($"Melancia baby | Quantidade: {quantidadeBaby:F2} kg | Valor Total: R$ {totalMelancia:F2}");


            }

            else if (opcao == 3)
            {
                double quantidadeComum, quantidadeBaby;
                valorPorKgMelancia = valorPorKgMelanciaComum;
                
                Console.Write("Digite a quantidade de melancia comum que deseja comprar: ");
                
                quantidadeComum = double.Parse(Console.ReadLine());
                totalMelanciaComum = quantidadeComum * valorPorKgMelancia * (1 - desconto);
                valorPorKgMelancia = valorPorKgMelanciaBaby;
                
                Console.Write("Digite a quantidade de melancia baby que deseja comprar: ");
                
                quantidadeBaby = double.Parse(Console.ReadLine());
                totalMelanciaBaby = quantidadeBaby * valorPorKgMelancia * (1 - desconto);
                totalMelancia = totalMelanciaComum + totalMelanciaBaby;
                
                Console.WriteLine($"Melancia comum | Quantidade: {quantidadeComum:F2} kg | Valor Total: R$ {totalMelanciaComum:F2}");
                Console.WriteLine($"Melancia baby | Quantidade: {quantidadeBaby:F2} kg | Valor Total: R$ {totalMelanciaBaby:F2}");
                Console.WriteLine($"Total das duas melancias | Quantidade: {(quantidadeComum + quantidadeBaby):F2} kg | Valor Total: R$ {totalMelancia:F2}");
            }
            
            Console.Write("Deseja comprar mais alguma coisa? (S/N): ");
            string resposta = Console.ReadLine();
            while (resposta.ToLower() == "s")
            {
                if (opcao == 1)
                {
                    valorPorKgMelancia = valorPorKgMelanciaComum;
                    
                    Console.Write("Digite a quantidade de melancia comum que deseja comprar: ");
                    
                    double quantidadeComum = double.Parse(Console.ReadLine());
                    totalMelancia = quantidadeComum * valorPorKgMelancia * (1 - desconto);
                    
                    Console.WriteLine($"Melancia comum | Quantidade: {quantidadeComum} kg | Valor Total: R$ {totalMelancia}");
                }
                else if (opcao == 2)
                {
                    valorPorKgMelancia = valorPorKgMelanciaBaby;
                    
                    Console.Write("Digite a quantidade de melancia baby que deseja comprar: ");
                    
                    double quantidadeBaby = double.Parse(Console.ReadLine());
                    totalMelancia = quantidadeBaby * valorPorKgMelancia * (1 - desconto);
                    
                    Console.WriteLine($"Melancia baby | Quantidade: {quantidadeBaby} kg | Valor Total: R$ {totalMelancia}");
                }
                else if (opcao == 3)
                {
                    double quantidadeComum, quantidadeBaby;
                    valorPorKgMelancia = valorPorKgMelanciaComum;
                    
                    Console.Write("Digite a quantidade de melancia comum que deseja comprar: ");
                    
                    quantidadeComum = double.Parse(Console.ReadLine());
                    totalMelanciaComum = quantidadeComum * valorPorKgMelancia * (1 - desconto);
                    valorPorKgMelancia = valorPorKgMelanciaBaby;
                    
                    Console.Write("Digite a quantidade de melancia baby que deseja comprar: ");
                    
                    quantidadeBaby = double.Parse(Console.ReadLine());
                    totalMelanciaBaby = quantidadeBaby * valorPorKgMelancia * (1 - desconto);
                    totalMelancia = totalMelanciaComum + totalMelanciaBaby;
                    
                    Console.WriteLine($"Melancia comum | Quantidade: {quantidadeComum:F2} kg | Valor Total: R$ {totalMelanciaComum:F2}");
                    Console.WriteLine($"Melancia baby | Quantidade: {quantidadeBaby:F2} kg | Valor Total: R$ {totalMelanciaBaby:F2}");
                    Console.WriteLine($"Total das duas melancias | Quantidade: {(quantidadeComum + quantidadeBaby):F2} kg | Valor Total: R$ {totalMelancia:F2}");
                }
                
                Console.Write("Deseja realizar outra compra? (S/N): ");
                string continuar = Console.ReadLine();
                if (continuar.ToLower() == "n")
                {
                    Console.WriteLine("Obrigado por comprar conosco! Volte sempre!");
                    Console.WriteLine("Aperte qualquer teclada para voltar!");
                    Console.ReadKey();
                    break;
                }
                else if (continuar.ToLower() == "s")
                {
                    Console.Write("Deseja comprar mais alguma coisa? (S/N): ");
                    resposta = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, digite S ou N.");
                    Console.ReadKey();
                    break;
                }
            }
        }
        static void RegistrarCaminhao()
        {
            Console.Write("Digite a placa do caminhão: ");
            string placa = Console.ReadLine();
            Console.Write("Digite o CPF/CNPJ do proprietário: ");
            string cpfCnpj = Console.ReadLine();
            Console.Write("Digite o modelo do caminhão: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite a capacidade de carga do caminhão: ");
            string capacidade = Console.ReadLine();


            string caminhao = $"{placa} | {cpfCnpj} | {modelo} | {capacidade}";
            caminhoes.Add(caminhao);


            Console.WriteLine($"Caminhão {placa} registrado com sucesso!");
        }

        static void BuscarCaminhoesPorProprietario()
        {
            Console.Write("Digite o CPF/CNPJ do proprietário: ");
            string cpfCnpj = Console.ReadLine();


            List<string> caminhoesEncontrados = caminhoes.FindAll(c => c.Contains(cpfCnpj));


            if (caminhoesEncontrados.Count > 0)
            {
                Console.WriteLine($"Caminhões registrados para o proprietário {cpfCnpj}:");
                foreach (string caminhao in caminhoesEncontrados)
                {
                    Console.WriteLine(caminhao);
                }
            }
            else
            {
                Console.WriteLine("Nenhum caminhão encontrado com o CPF/CNPJ informado.");
            }
        }


        static void Sair()
        {
            Console.WriteLine("Encerrando o programa...");
        }


    }
}

