using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Seu Nome: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite A Sua Idade: ");
            UInt32 Idade = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Digite o Numero do Seu Documento");
            string Documento = Console.ReadLine();

            Console.WriteLine("Digite o Nome da Sua Rua:");
            string NomeDaRua = Console.ReadLine();

            Console.WriteLine("Digite o Numero Da Casa:");
            UInt32 NumeroCasa = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Informe o Seu Genero: Pressione F para feminino e M para masculino");
            string Genero = Console.ReadKey(true).KeyChar.ToString(); //Estudar mais Esta Linha de Código


            Console.WriteLine("Olá " + Nome);
            Console.WriteLine("Voce tem: " + Idade + " Anos");
            Console.WriteLine("O Numero do documento informado é: " + Documento);
            Console.WriteLine("O nome da sua rua é: " + NomeDaRua);
            Console.WriteLine("o Numero da sua casa é: " + NumeroCasa);
            Console.WriteLine("O seu genero é: " + Genero);

            Console.WriteLine("Pressione Qualquer Tecla para Encerrar");
            Console.ReadKey();
        }
    }
}
