using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Número:");
           
            try //(tentar) Obrigatório - Sempre será executado
            {
                int i = Convert.ToInt32(Console.ReadLine());
                int resultado = 10 / i;
                Console.WriteLine($" o resultado da divisão é: {resultado}");

            }
            catch (DivideByZeroException e/*Tipo da exceção a ser gerenciada/tratada*/)//(pegar) Obrigatório - Só é executado em casa de exceção
            {
                Console.Write($"Exceção: {e.Message}");
            }

            catch(Exception e)
            {
                Console.Write($"Exceção genérica: {e.Message}");

            }
            finally//(Finalmente)Opcional - sempre será executado
            {
                Console.WriteLine("Pressione qualquer tecla para sair");
            }


            Console.ReadKey();
        }
    }
}
