using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Qaurto_Projeto
{
    internal class Program
    {
        struct DadosCadastrais_Struct //STRUCT é como uma "biblioteca" de variaveis
        {
            public string Nome;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
            public string NumeroDoDocumento;
        }
        static void Main(string[] args)
        {
            List<DadosCadastrais_Struct> ListaDeCadastros = new List<DadosCadastrais_Struct>();
            string opcao;
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuario ou S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if(opcao == "c")
                {
                    //Cadastrar um novo usuario
                    DadosCadastrais_Struct dadosCadastrais;
                    Console.WriteLine("Digite o nome completo:");
                    dadosCadastrais.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o nome da rua:");
                    dadosCadastrais.NomeDaRua = Console.ReadLine();
                    Console.WriteLine("Digite o numero da casa:");
                    dadosCadastrais.NumeroDaCasa = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Digite o numero do documento:");
                    dadosCadastrais.NumeroDoDocumento = Console.ReadLine();

                    ListaDeCadastros.Add(dadosCadastrais);
                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    //encerrar a aplicao
                    Console.WriteLine("Encerrando a aplicação");
                }
                else
                {
                    //opção desconhecida
                    Console.WriteLine("Opção desconhecida!");
                }
            } while(opcao != "s");

           /* int i = 0;
            foreach (DadosCadastrais_Struct Cadastros in ListaDeCadastros)
            {
                i++;
                Console.WriteLine(Cadastros);
            }*/


            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();    
        }
    }
}
