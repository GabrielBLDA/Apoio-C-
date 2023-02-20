using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Oitavo_Projeto
{
    internal class InterfaceGrafica
    {
        //Enum
        public enum Resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excecao = 2,
        }

        //Metodos antigos
        public void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public Resultado_e PegaString(ref string minhasString, string mensagem)
        {
            Resultado_e retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if( temp == "s" || temp == "S")
            {
                retorno = Resultado_e.Sair;
            }
            else
            {
                minhasString = temp;
                retorno = Resultado_e.Sucesso;
            }
            Console.Clear();
            return retorno;
        }

        public Resultado_e PegaData(ref DateTime data, string mensagem)
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
                        retorno = Resultado_e.Sair;
                    }
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    MostraMensagem($"EXCECAO: {e.Message}");
                    retorno = Resultado_e.Excecao;          
                }
            } while (retorno == Resultado_e.Excecao);
            Console.Clear() ;
            return retorno;
        }
        public  Resultado_e PegaUInt32(ref UInt32 numeroUInt32, string mensagem)
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
                        retorno = Resultado_e.Sair;
                    }
                    else
                    {
                        numeroUInt32 = Convert.ToUInt32(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    MostraMensagem($"EXCECAO: {e.Message}");
                    retorno = Resultado_e.Excecao;
                }
            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        //Atributo
        BaseDeDados baseDeDados;


        //Construtor
        public InterfaceGrafica(BaseDeDados pbaseDeDados)
        {
            baseDeDados = pbaseDeDados;
        }

        //Metodos novos
        public void ImprimeDadosNaTela(CadastroPessoa pPessoa)
        {
            Console.WriteLine($"Nome: {pPessoa.Nome}");
            Console.WriteLine($"Numero Do Documento: {pPessoa.NumeroDoDocumento}");
            Console.WriteLine($"Data De Nascimento: {pPessoa.DataDeNascimento}");
            Console.WriteLine($"Nome Da Rua: {pPessoa.NomeDaRua}");
            Console.WriteLine($"Numero Da Casa: {pPessoa.NumeroDaCasa}");
            Console.WriteLine("");
        }

        public void ImprimeDadosNaTela(List<CadastroPessoa> pListaDePessoas)
        {
            foreach (CadastroPessoa pessoa in pListaDePessoas)
            {
                ImprimeDadosNaTela(pessoa);
            }
        }

        public Resultado_e CadastraUsuario()
        {
            Console.Clear();
            string Nome = "";
            DateTime DataDeNascimento = new DateTime();
            string NumeroDoDocumento = "";
            string NomeDaRua = "";
            UInt32 NumeroDaCasa = 0;

            if(PegaString(ref Nome, "Digite o nome completo ou digite S para sair") == Resultado_e.Sair)
            {
                return Resultado_e.Sair;
            }
            if (PegaData(ref DataDeNascimento, "Digite a data de nascimento no formato DD/MM/AAAA ou digite S para sair") == Resultado_e.Sair)
            {
                return Resultado_e.Sair;
            }
            if (PegaString(ref NumeroDoDocumento, "Digite o numero do documento ou digite S para sair") == Resultado_e.Sair)
            {
                return Resultado_e.Sair;
            }
            if (PegaString(ref NomeDaRua, "Digite o nome da rua ou digite S para sair") == Resultado_e.Sair)
            {
                return Resultado_e.Sair;
            }
            if (PegaUInt32(ref NumeroDaCasa, "Digite o numero da casa ou digite S para sair") == Resultado_e.Sair)
            {
                return Resultado_e.Sair;
            }

            CadastroPessoa cadastroUsuario = new CadastroPessoa(Nome, NumeroDoDocumento, DataDeNascimento,  NomeDaRua, NumeroDaCasa);
            baseDeDados.AdicionarPessoa(cadastroUsuario);

            Console.Clear();
            Console.WriteLine("Adicionando usuario");
            ImprimeDadosNaTela(cadastroUsuario);
            MostraMensagem("");
            return Resultado_e.Sucesso;
        }


        public void BuscaUsuario()
        {
            Console.Clear();
            Console.WriteLine("Digite o numero do documento para busca o usuario ou digite S para sair");
            string temp = Console.ReadLine();
            if(temp.ToLower() == "s")
            {
                return;
            }
            List<CadastroPessoa> listaDePessoaTemp = baseDeDados.PesquisaPessoaPorDoc(temp);
            Console.Clear();
             if(listaDePessoaTemp != null)
            {
                Console.WriteLine($"Usuário(s) com documento {temp} encontrado(s)");
                ImprimeDadosNaTela(listaDePessoaTemp);
            }
            else
            {
                Console.WriteLine($"Nenhum usuario com o documento {temp} foi encontrado");
                MostraMensagem("");
            }

        }

        public void RemoveUsuario()
        {
            Console.Clear();
            Console.WriteLine("Digite o numero do documento para remover o usuario ou digite S para sair");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "s")
            {
                return;
            }
            List<CadastroPessoa> listaDePessoaTemp = baseDeDados.RemoverPessoaPorDoc(temp);
            Console.Clear();
            if (listaDePessoaTemp != null)
            {
                Console.WriteLine($"Usuário(s) com documento {temp} removidos(s)");
                ImprimeDadosNaTela(listaDePessoaTemp);
            }
            else
            {
                Console.WriteLine($"Nenhum usuario com o documento {temp} foi encontrado");
                MostraMensagem("");
            }

        }

        public void Sair()
        {
            Console.Clear();
            MostraMensagem("Encerrando o programa");
        }
        public void OpcaoDesconhecida()
        {
            Console.Clear();
            MostraMensagem("Opção desconhecida");
        }

        public void IniciaInterface()
        {
            string temp;
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário");
                Console.WriteLine("Digite B para buscar um usuario pelo numero do documento");
                Console.WriteLine("Digite R para remover um usuario pelo numero do documento");
                Console.WriteLine("Digite S para Sair");
                temp = Console.ReadKey(true).KeyChar.ToString().ToLower();

                switch (temp)
                {
                    case "c":
                        //cadastrar um usuario
                        CadastraUsuario();
                        break;
                    case "b":
                        //Busca um usuario
                        BuscaUsuario();
                        break;
                    case "r":
                        //Remove um usuario
                        RemoveUsuario();
                        break;
                    case "s":
                        //Sair
                        Sair();
                        break;
                    default:
                        //opcao desconhecida
                        OpcaoDesconhecida();
                        break;
                }

            } while (temp != "S");
        }
    }
}
