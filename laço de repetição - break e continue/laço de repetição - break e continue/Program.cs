using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laço_de_repetição___break_e_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pressione C para Continue");
                Console.WriteLine("Pressione E para Break");
                string tecla = Console.ReadKey(true).KeyChar.ToString();
                if(tecla == "c")
                {
                    continue;
                }
                else if (tecla == "e")  
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Pressione qualquer tecla para Sair");
            Console.ReadKey();
        }
    }
}
