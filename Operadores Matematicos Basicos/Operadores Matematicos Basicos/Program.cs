using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Matematicos_Basicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //soma +
            double numero1 = 15.5;
            double numero2 = 10;
            double resultadoSoma = numero1 + numero2;
            Console.WriteLine("O resultado da soma de " + numero1 + " + " + numero2 + " é: " + resultadoSoma);
           
            //Subtração
            double resultadoSubtracao = numero1 - numero2;
            Console.WriteLine("O resultado da subtração de " + numero1 + " - " + numero2 + " é: " + resultadoSubtracao);

            //Multiplicação
            double resultadoMultiplicacao = numero1 * numero2;
            Console.WriteLine("O resultado da multiplicacao de " + numero1 + " * " + numero2 + " é: " + resultadoMultiplicacao);

            //Divisão
            double resultadoDivisao = numero1 / numero2;
            Console.WriteLine("O resultado da Divisão de " + numero1 + " / " + numero2 + " é: " + resultadoDivisao);

            // Resto %
            int numero3 = 5;
            int numero4 = 3;
            int resultasdoResto = numero3 % numero4;
            Console.WriteLine("O RESTO da Divisão de " + numero3 + " por " + numero4 + " é: " + resultasdoResto);

            //Somar ou subtrair um valor ao conteudo de uma variavel
            double numero5 = 10;
            numero5 += 10; //numero1 5 = numero5 + 10;
            Console.WriteLine("O resultado da soma de " + 10 + " mais " + 10 + " é: " + numero5);
            numero5 -= 10; //numero1 5 = numero5 - 10;
            Console.WriteLine("O resultado da subtração de " + 10 + " menos " + 10 + " é: " + numero5);

            //Dividir e multiplicar o valor do conteudo de uma variavel por outro valor
            numero5 *= 10; //numero1 5 = numero5 * 10;
            Console.WriteLine("O resultado da multiplicao de " + 10 + " vezes " + 10 + " é: " + numero5);
          
            numero5 = 10;
            numero5 /= 10; //numero1 5 = numero5 / 10;
            Console.WriteLine("O resultado da divisao de " + 10 + " divido por  " + 10 + " é: " + numero5);

            //Incremento ++
            double numero6 = 10;
            //numero6 = numero6 + 1;
            //numero6  += 1;
            numero6++;
            Console.WriteLine("O resultado da operação incremento de " + 10 + " é: " + numero6);

            //Decremento ++
            double numero7 = 10;
            //numero7 = numero7 - 1;
            //numero7  -= 1;
            numero7--;
            Console.WriteLine("O resultado da operação decremento de " + 10 + " é: " + numero7);

            Console.ReadKey();
        }
    }
}
