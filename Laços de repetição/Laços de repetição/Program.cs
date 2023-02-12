using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços_de_repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Laço/Loop for
            for (int i = 0/*inicialização da nossa variavel*/; i < 10/*Condição */; i++/*Alteração da variavel */ ){
                Console.WriteLine(i);
            }

            Console.WriteLine("\r\n");//corta linha

            //Laço while
            int j = 0;
            while(j<=100/*Condição*/){
                Console.WriteLine(j);
                j += 10;
            }

            Console.WriteLine("\r\n");//corta linha


            //Laço do... while
            int k = 0;
            do //Faça enquanto
            {
                Console.WriteLine(k);
                k += 50;
            } while (k<1000/*Condição*/);


            Console.WriteLine("\r\n");//corta linha


            //Laço foreach (para cada)  (precisa de um array para esta forma de repetição
            string[] nomes = {"Pato", "Dom", "Maria", "Goin","Gabriel", "Nando" }; 
            foreach(string nome in nomes/*Funcionamento do nosso array*/)
            {
                if (nome == "Gabriel")
                {
                    break;
                }
                
                else { Console.WriteLine(nome); }
            }

            Console.ReadKey();
        }
    }
}
