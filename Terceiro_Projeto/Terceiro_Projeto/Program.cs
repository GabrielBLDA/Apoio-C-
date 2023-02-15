using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terceiro_Projeto
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Pressione C para castrar um usuario ou S para sair:");               
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    Console.WriteLine("Digite seu nome Completo:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite seu genero M para masculino F para feminino:");
                    char genero = Console.ReadKey(true).KeyChar;
                    Console.WriteLine("Digite a data do seu nacimento no formato dd/mm/aaaa:");
                    DateTime dataDeNascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Digite o nome da rua:");
                    string nomeDaRua= Console.ReadLine();
                    Console.WriteLine("Digite o numero da casa:");
                    UInt32 numerodacasa = Convert.ToUInt32(Console.ReadLine());
                    Console.Clear();

                }
                else if (opcao == "s")
                {
                    Console.WriteLine("Encerrando o Programa");

                }
                else
                {
                    Console.WriteLine("Opção desconhecida");
                }
            } while (opcao != "s");
            {
                Console.WriteLine("Pressione Qualquer Tecla para sair");
                Console.ReadKey();
            }
        }
    }
}
