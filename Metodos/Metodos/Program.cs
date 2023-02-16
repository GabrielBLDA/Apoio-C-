using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        //Tipo_de_acesso  modificador_de_instancia  tipo_de_retorno  nome_do_metodo(paramentros_de_entrada)
        public static double Soma(double a, double b)
        {
            double resultadoSoma = a + b;
            return resultadoSoma;
        }

        public static void ImprimeMensagens()
        {
            Console.WriteLine("Olá! este é um metodo vazio!");
            Console.WriteLine("Ele não tem parametros de entrada e nem de retorna nada");
        }

        //Modificador de parametros de entrada
        /*
         ref - sinaliza que o parametro de entra PODE ser modificado pelo método
         out - sinaliza que o parametro de entrada DEVE ser modificado pelo métido               
         */
        public static void Multiplica(double a, double b, ref double resultadoDaOperacao)
        {
            double resultadoMultiplica = a * b;
            resultadoDaOperacao = resultadoMultiplica;
        }

        public static void Multiplica2(double a, double b, out double resultadoDaOperacao)
        {
            double resultadoMultiplica = a * b;
            resultadoDaOperacao = resultadoMultiplica;
        }

        static void Main(string[] args)
        {
            //Chamando metodos 
            double resultado = Soma(10, 20);
            Console.WriteLine($"O resultado da soma de 10 e 20 é: {resultado}");

            double numero1 = 20;
            double numero2 = 30.5;
            resultado = Soma(numero1, numero2);
            Console.WriteLine($"O resultado da soma de {numero1} e {numero2} é: {resultado}");


            ImprimeMensagens();

            double resultadoMultiplica = 0;
            Multiplica(numero1, numero2, ref resultadoMultiplica);
            Console.WriteLine($"O resultado da multiplicação é: {resultadoMultiplica}");

             resultadoMultiplica = 0;
            Multiplica2(numero1, numero2, out resultadoMultiplica);
            Console.WriteLine($"O resultado da multiplicação é: {resultadoMultiplica}");

            Console.ReadKey();
        }
    }
}
