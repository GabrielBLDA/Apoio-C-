using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipular_Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //CRIANDO CAMINHOS DE ARQUIVO
            //PRIMEIRO METODO
            string caminho1 = "C:\\Users\\klebe\\Desktop\\teste\\teste.txt";
            //segunda maneira
            string caminho2 = @"C:\Users\klebe\Desktop\teste\teste.txt";


            //Criando um arquivo
            FileStream meuArquivo = File.Create(caminho1);
            meuArquivo.Close();


            //verificando se um arquivo existe
            bool arquivoExiste = File.Exists(caminho1);
            if(arquivoExiste)
            {
                Console.WriteLine("O arquivo existe");
            }
            else
            {
                Console.WriteLine("O arquivo nao existe");
            }

            //Deletando Arquivos
            File.Delete(caminho1);

            //Renomeando ou movendo arquivos
            caminho2 = @"C:\Users\klebe\Desktop\teste\teste2.txt";
            FileStream meuArquivo2 = File.Create(caminho2);
            meuArquivo2.Close();
            string caminho3 = @"C:\Users\klebe\Desktop\teste\teste3.txt";
            File.Move(caminho2, caminho3);


            //Escrevendo em um arquivo de texto
            string  caminho5 = @"C:\Users\klebe\Desktop\teste\Nomes.txt";
            FileStream meuArquivo3 = File.Create(caminho5);
            meuArquivo3.Close();

            string conteudo = "Bilada é um cara muito legal \r\npedro é um cara muito inteligente ";
            File.WriteAllText(caminho5, conteudo);


            //Escrevendo um array de strings no nosso arquivo
            string[] conteudoArray = { "Goin", "Nando", "chimia", "Dom O caça dragão" };
            File.WriteAllLines(caminho5, conteudoArray);


            //lendo todo o conteudo de um arquivo
            string conteudoLido = File.ReadAllText(caminho5);
            Console.WriteLine(conteudoLido);


            //Lendo o conteudo de um arquivo e graavando num array de strings
            Console.WriteLine("---------------");
            string[] conteudoLidoArray = File.ReadAllLines(caminho5);
            foreach (string nomes in conteudoLidoArray)
            {
                Console.WriteLine(nomes);
            }


            Console.ReadKey();
        }
    }
}
