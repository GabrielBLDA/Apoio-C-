using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite S para sair ou um numero para calcular o fatorial");
                string opcao = Console.ReadLine();
                if (opcao == "s" || opcao == "S")
                break;

                else
                {
                    int valor = Convert.ToInt32(opcao);
                    if (valor == 0)
                    {
                        Console.WriteLine("0! = 1");
                    }else if (valor<0)
                    {
                        Console.WriteLine("impossivel calcular o fatorial de um numero negativo");
                    }else
                    {
                        int resultado = 1;
                        for (int i = valor; i > 0; i--)
                        {
                            resultado *= i;
                        }
                        Console.WriteLine($"O resultado de {valor} fatorial é: {resultado}");
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.ReadLine();
        }
    }
}
