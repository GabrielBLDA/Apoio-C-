using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_lógicos_entre_variaveis_numericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //negação -> ~
            int var1 = 0b11001100; //0b para indicar o que o valor e binario
            int resultadoNegacao = ~var1;
            Console.WriteLine("O resultado da negação de " + Convert.ToString(var1, 2) + " é: " + Convert.ToString(resultadoNegacao, 2));

            Console.Write("\r\n");

            //Operador OU (OR) -> |
            int var2 = 0b11001100; //0b para indicar o que o valor e binario
            int var3 = 0b11110000; //0b para indicar o que o valor e binario
            int resultadoOU = var2 | var3;
            Console.WriteLine("O resultado da operação OU entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resultadoOU, 2));//FEZ UMA OPERAÇÃO BIT A BIT TRANSFORMANDO OS 0 EM 1 (OU FALSE EM TRUE)

            Console.Write("\r\n");

            //Operador E (AND) -> &
            int resultadoE = var2 & var3;
            Console.WriteLine("O resultado da operação E entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resultadoE, 2));//FEZ UMA OPERAÇÃO BIT A BIT (1 COM 0 DA FALSE) (1 COM 1 DA TRUE) (0 COM 0 DA FALSE) 

            Console.Write("\r\n");

            //Operador OU EXCLUSIVO (XOR) -> ^
            int resultadoXOR = var2 ^ var3;
           Console.WriteLine("O resultado da operação XOR entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resultadoXOR, 2));//FEZ UMA OPERAÇÃO BIT A BIT (1 COM 0 DA FALSE) (1 COM 1 DA TRUE) (0 COM 0 DA FALSE)  

            Console.Write("\r\n");

            //Operador ->  > e < 
            int var4 = 10;
            int var5 = 20;
            Console.WriteLine("O valor de " + var4 + " é > " + var5 + "?: " + (var4 > var5));
            Console.WriteLine("O valor de " + var5 + " é > " + var4 + "?: " + (var5 > var4));
            Console.WriteLine("O valor de " + var4 + " é < " + var5 + "?: " + (var4 < var5));
            Console.WriteLine("O valor de " + var5 + " é < " + var4 + "?: " + (var5 < var4));

            Console.Write("\r\n");

            //Operador -> >= e <=
            Console.WriteLine("O valor de " + var4 + " é >= " + var5 + "?: " + (var4 >= var5));
            Console.WriteLine("O valor de " + var5 + " é >= " + var4 + "?: " + (var5 >= var4));
            Console.WriteLine("O valor de " + var4 + " é <= " + var5 + "?: " + (var4 <= var5));
            Console.WriteLine("O valor de " + var5 + " é <= " + var4 + "?: " + (var5 <= var4));
            Console.WriteLine("O valor de " + var4 + " é <= " + var4 + "?: " + (var4 <= var4));
            Console.WriteLine("O valor de " + var5 + " é <= " + var5 + "?: " + (var5 <= var5));

            Console.Write("\r\n");

            //Operador igual -> ==
            bool resultadoIgual = (var4 == var4);
            Console.WriteLine("O valor de " + var4 + " é igual a " + var4 + "?: " + resultadoIgual);
            Console.WriteLine("O valor de " + var4 + " é igual a " + var5 + "?: " + (var4==var5));
            Console.ReadKey();

        }
    }
}

