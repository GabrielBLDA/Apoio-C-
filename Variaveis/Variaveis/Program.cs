using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Idade;
            Idade = 18;
            Console.WriteLine(Idade);
           
            Idade = 20;
            Console.WriteLine(Idade);

            string NomeCompleto = "Gabriel Abreu";
            Console.WriteLine(NomeCompleto);

            NomeCompleto = "Eduardo Veiga";
            Console.WriteLine(NomeCompleto);


            // byte b = 10000; o valor 10000 é muito grande para uma variavel do tipo byte //


           var salario = 10000;//O compilador atribuiu a variavel do tipo var para int automaticamente por conta do valor inserido
            var NomeDaMae = "Aline";//O compilador atribuiu a variavel do tipo var para String automaticamente por conta do valor inserido
           //nomeD
           //aMae = 10000; Isso não é possivel, pois o compilador já atribuiu o tipo de string para a nossa variavel.

           DateTime DataDeNascimento = new DateTime(2002, 7, 10, 7, 15, 10);
           Console.WriteLine("Naceu no Ano de: " + DataDeNascimento.Year);
           Console.WriteLine("Nome Mês de: " + DataDeNascimento.Month);
           Console.WriteLine("No Dia: " + DataDeNascimento.Day);
           Console.WriteLine("As: " + DataDeNascimento.Hour + " Horas");
           Console.WriteLine("Aos: " + DataDeNascimento.Minute + " Minutos");
           Console.WriteLine("E aos: " + DataDeNascimento.Second + " Segundos");


            string NumeroDaCasa = "65"; //conversao de variavel
            int NumeroDaCasaInt = Convert.ToInt32(NumeroDaCasa); //Converte para inteiro o valor da variavel numero casa
            Console.WriteLine(NumeroDaCasaInt);


            string NumeroDaCasa2 = Convert.ToString(NumeroDaCasaInt); //Converte Para string o valor da variavel NumeroDaCasaInt;
            Console.WriteLine(NumeroDaCasaInt);


            byte b = 50;
            char c = Convert.ToChar(b); //Utilizas a tabela ASCII.
            Console.WriteLine(c);


            int charC = Convert.ToInt32(c);//Converte o caracter 2 devolta para o 50 atraves da tabela ASCII.
            Console.WriteLine(charC);


            double d = 1.2;
            Console.WriteLine(d);
            int conversaoDoDouble = Convert.ToInt32(d);//A conversão acaba arredondando o valor do double "1.6" para dois por conta do tipo INT que não recebem valores fracionados
            Console.WriteLine(conversaoDoDouble);


            int NumeroGrande = 1000;
            byte NumeroPequeno = Convert.ToByte(NumeroGrande);
            Console.WriteLine(NumeroPequeno);

            Console.ReadKey();
        }
    }
}
