using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_Classes
{
    public class ContaBancaria
    {

        //atributos
        private double saldo;
        private string senha;
        private string nomeDoCliente;


        //Metodos
        //MODIFICADOR_DE_ACESSO TIPO_DE_SAIDA NOME_DO_METODO (TIPO_PAR1 NOME_PAR1, TIPO_PAR2 NOME_PAR2, ...)
        //{
        //  CONTEUDO DO METODO
        //  return VALOR_DE_SAIDA;
        //}

        //MODIFICADORES_DE_ACESSO
        //public (public) - Todos podem acessar o nosso metodo
        //private (privado) - Somente a nossa propria classe pode acessar o metodo

        //TIPO_DE_SAIDA
        //EXEMPLO: int, string, bool, class, List...

        //PARAMETROS_DE_ENTRADA
        //TIPO_PAR1: int, string, class, List ...
        //NOME_PAR: QUALQUERNOME

        public double Sacar(double pValorSacado, string pSenha)
        {
            if (senha == pSenha)
            {
                if(saldo > pValorSacado)
                {
                    saldo -= pValorSacado;
                    Console.WriteLine($"O valor sacado foi de: {pValorSacado}");
                    return pValorSacado;        
                }
                else
                {
                    Console.WriteLine($"O saldo é insuficiente");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine($"A senha está incorreta");
                return 0;
            }
        }

        public void Depositar(double pValorDepositado)
        {
            saldo += pValorDepositado;
            Console.WriteLine($"O valor depositado foi de: {pValorDepositado} Reais");
        }

        public void ConsultaSaldo(string pSenha)
        {
            if (senha == pSenha)
            {
                Console.WriteLine($"O saldo da conta é : {saldo} reais");
            }
            else
            {
                Console.WriteLine("A senha está incorreta");
            }
        }


        //Esse é o metodo construtor
        //Primeiro metodo a ser executado quando instaciamos a classe/Criamos um objeto
        //Construtor nao possui parametro de saida
        //O construtor é sempre publico
        //Normalmente o construtor é usado para fazer as configurações iniciais do nosso objeto
        public ContaBancaria(string pSenha, string pNomeDoCliente) //Construtor
        {
            saldo = 0;
            senha = pSenha;
            nomeDoCliente = pNomeDoCliente;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando objeto apartir de uma classe existente
            ContaBancaria contaDoBilada = new ContaBancaria("12345", "Bilada Abreu");
            
            double valorSacado = contaDoBilada.Sacar(10, "12345");
            contaDoBilada.Depositar(1000);
            contaDoBilada.ConsultaSaldo("12345");
            valorSacado = contaDoBilada.Sacar(10, "12345");


            Console.ReadKey();
        }
    }
}
