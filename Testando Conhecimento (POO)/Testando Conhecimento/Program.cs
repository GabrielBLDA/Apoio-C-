using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Testando_Conhecimento
{
    internal class Program
    {
        public class Locadora
        {
            //Atributos
            public string nomeCliente;
            public string senha;
            public bool situacaoAluguel;


            //metodos
            public void AnalisarSituação(string pSenha)
            {
                if(pSenha == senha && situacaoAluguel == true)
                {
                    Console.WriteLine($"{nomeCliente} está apto a alugar um filme em nossa locadora");
                   
                }
                else if (pSenha != senha)
                {
                     Console.WriteLine("A senha inserida esta incorreta"); 
                }
                else
                {
                    Console.WriteLine("Você ainda não pode alugar nenhum filme em nossa locadora, pois ainda não devolveu o ultimo");
                }

            }  

            public void DevolverFilme(string pSenha)
            {
                if(pSenha == senha)
                {
                     
                    Console.WriteLine($"Acesso autorizado! seja bem vindo {nomeCliente}");
                    if(situacaoAluguel != true)
                    {
                        Console.WriteLine($"Você devolveu seu filme! muito obrigado!");
                        situacaoAluguel = true;
                    }
                    else
                    {
                        Console.WriteLine($"Você Não tem Filmes para devolver no momento!");
                    }
                }
                else
                {
                    Console.WriteLine($"Senha incorreta!");
                }
            }

            public void AlugarFilme(string psenha)
            {
                if (psenha == senha)
                {
                    Console.WriteLine($"Acesso autorizado! seja bem vindo {nomeCliente}");
                    if (situacaoAluguel != true)
                    {
                        Console.WriteLine($"Você Não pode alugar um filme");
                    }
                    else
                    {
                        Console.WriteLine($"Você Alugou um filme!");
                        situacaoAluguel = false;
                    }
                }
                else
                {
                    Console.WriteLine($"Senha incorreta!");
                }
            }

            public Locadora (string pSenha, string pNomeCliente) //METODO CONSTRUTOR
            {
                senha = pSenha;
                nomeCliente = pNomeCliente;
                situacaoAluguel = true;
            }
     
        }
        static void Main(string[] args)
        {
            Locadora ContaBilada = new Locadora("12345", "Gabriel Abreu de Lima"); //Criando obj

            ContaBilada.AnalisarSituação("12345");
            Console.WriteLine(); 

            ContaBilada.DevolverFilme("12345");
            Console.WriteLine();

            ContaBilada.AlugarFilme("12345");
            Console.WriteLine();

            ContaBilada.DevolverFilme("12345");
            Console.WriteLine();

            ContaBilada.DevolverFilme("12345");
            Console.WriteLine();

            ContaBilada.AlugarFilme("12345");
            Console.WriteLine();

            ContaBilada.AlugarFilme("12345");
            Console.WriteLine();

            ContaBilada.AnalisarSituação("12345");
            Console.WriteLine();

            ContaBilada.DevolverFilme("12345");
            Console.WriteLine();

            ContaBilada.AnalisarSituação("12345");
            Console.WriteLine();

            ContaBilada.DevolverFilme("12345");
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
