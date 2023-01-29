using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_lógicos_entre_variaveis_booleanas
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Operadores Lógicos entre variaveis booleanas");
            Console.Write("\r\n");

            bool var1 = true; //verdadeiro
            bool var2 = false; //falso

            //negação -> !
            bool resultadoNegacao = !var1; //a variavel boll(so recebe true ou false) rece a negacao ! de var1 que é falso
            Console.WriteLine("a negação de " + var1 + " é: " + var2);
            resultadoNegacao = !var2; //a variavel boll(so recebe true ou false) rece a negacao ! de var2 que é verdadeiro 
            Console.WriteLine("a negação de " + var2 + " é: " + var1);

            Console.Write("\r\n");

            //Operador E (AND) -> &
            bool resultadoE = var1 & var1;
            Console.WriteLine("O resultado da operação E entre " + var1 + " e " + var1 + " Resulta em: " + resultadoE);
            resultadoE = var1 & var2;
            Console.WriteLine("O resultado da operação E entre " + var1 + " e " + var2 + " Resulta em: " + resultadoE);
            resultadoE = var2 & var2;
            Console.WriteLine("O resultado da operação E entre " + var2 + " e " + var2 + " Resulta em: " + resultadoE);

            Console.Write("\r\n");

            //Operador OU (OR) -> |
            bool resultadoOU = var1 | var1;
            Console.WriteLine("O resultado da operação OU entre " + var1 + " e " + var1 + " Resulta em: " + resultadoOU);
            resultadoOU = var1 | var2;
            Console.WriteLine("O resultado da operação OU entre " + var1 + " e " + var2 + " Resulta em: " + resultadoOU);
            resultadoOU = var2 | var2;
            Console.WriteLine("O resultado da operação 0U entre " + var2 + " e " + var2 + " Resulta em: " + resultadoOU);

            Console.Write("\r\n");

            //Operador OU EXCLUSIVO (XOR) -> ^
            bool resultadoXOR = var1 ^ var1;
            Console.WriteLine("O resultado da operação XOR entre " + var1 + " e " + var1 + " Resulta em: " + resultadoXOR);
            resultadoXOR = var1 ^ var2;
            Console.WriteLine("O resultado da operação XOR entre " + var1 + " e " + var2 + " Resulta em: " + resultadoXOR);
            resultadoXOR = var2 ^ var2;
            Console.WriteLine("O resultado da operação XOR entre " + var2 + " e " + var2 + " Resulta em: " + resultadoXOR);

            Console.Write("\r\n");

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
