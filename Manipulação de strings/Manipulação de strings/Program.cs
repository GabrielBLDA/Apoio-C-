using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Manipulação_de_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indexação
            string nome = "Guilherme";
            char letra = nome[4];
            Console.WriteLine(letra);

            //Concatenar string
            string sobrenome = " Silva sauro";
            string nomecompleto = nome + sobrenome;
            Console.WriteLine(nomecompleto);

            string nomecompleto2 = string.Concat(nome, sobrenome);
            Console.WriteLine(nomecompleto2);


            //Substituição de strings
            string endereco = "Ruas das Rosas Verdes";
            endereco = endereco.Replace("Verdes", "Vermelhas");
            Console.WriteLine(endereco);

            //Remoção de strings 
            string endereco2 = "Ruas das Rosas Verdes";
            endereco2 = endereco2.Replace("Verdes", "");
            Console.WriteLine(endereco2);

            string endereco3 = "Ruas das Rosas Verdes";
            endereco3 = endereco3.Remove(0, 4);
            Console.WriteLine(endereco3);


            //Capitalização de string (MAIUSCULO E MINUSCULO)
            string nome2 = "João da Silva";
            nome2 = nome2.ToUpper();//transforma tudo para maiusculo
            Console.WriteLine(nome2);
            nome2 = nome2.ToLower();//transforma tudo para maiusculo
            Console.WriteLine(nome2);


            //Contém
            string nome3 = "João da Silva";
            bool contem = nome3.Contains("João");
            Console.WriteLine(contem);

            contem = nome3.Contains("marcos");
            Console.WriteLine(contem);

            //Localização de textos
            string nome4 = "Gabriel Abreu de Lima";
            int indice = nome4.IndexOf("Lima");
            Console.WriteLine(indice);

            //Divisão de string
            string nome5 = "Joao da silva";
            string[] divisores = {"da"};
            string[] resultasdoDaDivisao = nome5.Split(divisores, StringSplitOptions.None);
            foreach(string texto in resultasdoDaDivisao)
            {
                Console.WriteLine(texto);
            }

            //Numero de catacters 
            string nome6 = "Joao da silva";
            int numerocaracteres = nome6.Length;
            Console.WriteLine(numerocaracteres);

            //Substring
            string nome7 = "Joao da silva";
            string ultimoNome = nome7.Substring(8, 5);
            Console.WriteLine(ultimoNome);

            //Formatação composta
            string nome8 = "Joao {0} {1}";
            Console.WriteLine(nome8, "da silva", "sauro");


            Console.ReadKey();
        }
    }
}
