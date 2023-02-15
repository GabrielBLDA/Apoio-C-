using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLoginConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("Digite o nome do seu usuario: ");
                string usuario = Console.ReadLine();
                Console.Write("Digite a sua senha: ");
                string senha = "";
                while (true)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.Enter)
                        break;

                    else
                    {
                        senha += tecla.KeyChar;
                    }
                }
                if (usuario == "Valeria" && senha == "1234")
                {
                    Console.WriteLine("usuario logado com sucesso");
                    break;
                }
                else
                {
                    Console.WriteLine("Usario ou senha incorreto");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.WriteLine("Pressione Qualquer tecla para sair");
                Console.ReadKey();
            }
          

        }
    }
}
