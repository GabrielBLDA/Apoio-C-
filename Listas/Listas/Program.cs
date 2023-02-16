using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int>ListaNumeros = new List<int>();

            Console.WriteLine("Qual a quantidade de numeros que você quer adicionar na lista Numeros:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            while (ListaNumeros.Count != quantidade)
            {
            Console.WriteLine("Adicione um numero na lista: ");
            ListaNumeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int i = 0;
            foreach (int numero in ListaNumeros)
            {
                i++;
                Console.WriteLine($"[{i}]: {numero}");
            }

            Console.ReadKey();
        }
    }
}
