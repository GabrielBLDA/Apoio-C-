using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificador_static_e_palavra_this
{
    //Modificador static (estatico ou fixo) - Ele é sempre usado apos o modificador de acesso
    //O static transforma o que esta sendo modificado por ele em pertencente á classe e não mais ao objeto.
    //Pode ser usado em:
    //atributo
    //propriedade
    //metodo
    //struct
    //classe
    //...

    //Não tem nada estatico na classe pessoa
    public class Pessoa
    {
        //atributo
        private string nome;

        //propriedade de classe
        public string Nome { get; set; }


        //metodo
        public void ImprimeNome()
        {
            Console.WriteLine($"O nome é {nome}");
        }
        //metodo construtor

        public Pessoa(string pNome)
        {
            nome = pNome;
        }
    }

    //Palavra this (este) - é utilizado para se referir aquilo que pertence a nossa classe
    public class MinhaPessoa
    {
        //atributo
        private string nome;

        //propriedade de classe
        public string Nome { get; set; }


        //metodo
        public void ImprimeNome()
        {
            Console.WriteLine($"O nome é {nome}");
        }

        //metodo construtor
        public MinhaPessoa(string nome)
        {
            this.nome = nome;
        }
    }

    //A classe calculadora possue o modificador static
    public class Calculadora
    {
            public static double PI = 3.14;

            public static double CalculaAreaCircunferencia(double pRaio)
            {
                return PI * Math.Pow(pRaio, 2);
            }     
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("João");
            Pessoa pessoa2 = new Pessoa("Pedro");

            pessoa1.ImprimeNome();
            pessoa2.ImprimeNome();

            //chamar static só pode ser acessaado apartir do nome da classe, pois ele pertence a classe
            Console.WriteLine($"O valor de PI é: {Calculadora.PI}");
            Console.WriteLine($"A area é {Calculadora.CalculaAreaCircunferencia(5)}");
            Calculadora calc = new Calculadora();
           

            Console.ReadKey();
        }
    }
}
