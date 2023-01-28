using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra_de_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu nome completo:");       
            string Nome = Console.ReadLine();
            Console.WriteLine("Seja Bem Vindo " + Nome);
            Console.WriteLine("Insira a Sua Idade");
            string Idade = Console.ReadLine();
            var IdadeInt = Convert.ToInt32(Idade);

            if (IdadeInt < 18)
            {
                Console.WriteLine("Você é menor de idade");
            } else
            {
                Console.WriteLine("Você é maior de idade");
            }

            Console.WriteLine("Pressione qualquer Tecla:");
            char teclaPressionada = Console.ReadKey(true).KeyChar;

            Console.WriteLine("A tecla pressionado foi: " + teclaPressionada);

            Console.WriteLine("Pressione Qualquer tecla para sair");
            Console.ReadKey();
        } 
    }
}
