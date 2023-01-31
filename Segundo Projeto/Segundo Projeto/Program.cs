using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione A para alugar um filme ou S para Sair da locadora:");
            char opcao = Console.ReadKey(true).KeyChar;
            if (opcao == 'A' || opcao == 'a')
            {
                //Alugar filme
                Console.WriteLine("Pressione 1 para alugar Top gun");
                Console.WriteLine("Pressione 2 para alugar A Bela e a Fera");
                Console.WriteLine("Pressione 3 para alugar O Homem Aranha");

                int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());

                switch(opcaoFilme)
                {
                    case 1:
                        Console.WriteLine("Voce alugou Top Gun");
                        break;
                    case 2:
                        Console.WriteLine("Voce alugou A Bela e a Fera");
                        break;
                    case 3:
                        Console.WriteLine("Voce alugou O Homem Aranha");
                        break;
                    default:
                        Console.WriteLine("Opcao desconhecida");
                        break;
                }
            }
            else if (opcao == 'S' || opcao == 's')
            {
                //Sair Da locadora
                Console.WriteLine("Muito Obrigado Voltei Sempre!");
            }
            else
            {
                //Opcao desconhecida
                Console.WriteLine("Opcao desconhecida ...");
            }
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
        }
    }
}
