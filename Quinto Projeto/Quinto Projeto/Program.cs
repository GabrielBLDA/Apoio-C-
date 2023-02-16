using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinto_Projeto
{
    internal class Program
    {
        public struct DadosCadastraisStruct
        {
            public string Nome;
            public DateTime DataDeNascimento;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
        }

        public enum Resultado_e
        {
            sucesso = 0,
            sair = 1,
            Excecao = 2
        }

        public static void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public static Resultado_e PegaString(ref string minhaString, string mensagem)
        {
            Resultado_e retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if (temp == "s" || temp == "S")
            {
                retorno = Resultado_e.sair; 
            }
            else 
            {
                minhaString = temp;
                retorno = Resultado_e.sucesso;
            }
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaData(ref DateTime data, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.sair;
                    }
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Execessão: {e.Message}");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;
                }


            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaUint32(ref UInt32 numeroUint32, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.sair;
                    }
                    else
                    {
                        numeroUint32 = Convert.ToUInt32(temp);
                        retorno = Resultado_e.sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Execessão: {e.Message}");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;
                }


            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        public static void CadastrarUsuario(ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            DadosCadastraisStruct cadastroUsuario;
            cadastroUsuario.Nome = "";
            cadastroUsuario.DataDeNascimento = new DateTime();
            cadastroUsuario.NomeDaRua = "";
            cadastroUsuario.NumeroDaCasa = 0;
            if (PegaString(ref cadastroUsuario.Nome, "Digite o nome completo ou Digite S para Sair") != Resultado_e.sucesso)
            {
                return;
            }
            if(PegaData(ref cadastroUsuario.DataDeNascimento, "Digite a data de nascimento no formato DD/MM/AAAA ou digite S para sair") != Resultado_e.sucesso)
            {
                return;
            }
            if(PegaString(ref cadastroUsuario.NomeDaRua, "Digite o Nome da rua ou digite S para sair") != Resultado_e.sucesso)
            {
                return;
            }
            if(PegaUint32(ref cadastroUsuario.NumeroDaCasa,"Digite o Numero da casa ou digite S para sair") != Resultado_e.sucesso)
                    {
                return;
            }
            ListaDeUsuarios.Add(cadastroUsuario);
        }

        static void Main(string[] args)
        {
            List<DadosCadastraisStruct> ListaDeUsuarios = new List<DadosCadastraisStruct>();
            string opcao = "";
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuario ou S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    CadastrarUsuario(ref ListaDeUsuarios);
                }
                else if (opcao == "s")
                {
                    MostraMensagem("Encerrando o programa");
                }
                else
                {
                    MostraMensagem("Opção desconhecida");

                }
            } while (opcao != "s");
                      
        }
    }
}
