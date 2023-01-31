using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mais_sobre_operadores_Lógicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;
            bool resultadoOU_1 = var1 | var2; //ambos funcionam como operadores OU
            bool resultadoOU_2 = var1 || var2;  //ambos funcionam como operadores OU

            Console.WriteLine(resultadoOU_1);
            Console.WriteLine(resultadoOU_2);

            bool resultadoE_1 = var1 & var2;  //ambos funcionam como operadores E
            bool resultadoE_2 = var1 && var2; //ambos funcionam como operadores E mas este e mais rapido

            Console.WriteLine(resultadoE_1);
            Console.WriteLine(resultadoE_2);

            Console.WriteLine("Pressione Qualquer Tecla Para SAIR.");
            Console.ReadKey();
        }
    }
}
