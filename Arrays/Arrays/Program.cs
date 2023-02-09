using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----array de 1 dimensão-----");
            Console.WriteLine("Exemplo Código:  int[] MeuArray1 = new int[3];");
            int[] MeuArray1 = new int[3];
            MeuArray1[0] = 1;
            MeuArray1[1] = 10;
            MeuArray1[2] = 100;
            Console.WriteLine(MeuArray1[0]);
            Console.WriteLine(MeuArray1[1]);
            Console.WriteLine(MeuArray1[2]);

            Console.WriteLine("\r\n");

            Console.WriteLine("-----Outras maneiras de criar um array-----");
            Console.WriteLine("Exemplo Código: int[] MeuArray2 = { 2, 20, 200 };");
            int[] MeuArray2 = { 2, 20, 200 };
            Console.WriteLine(MeuArray2[0]);
            Console.WriteLine(MeuArray2[1]);
            Console.WriteLine(MeuArray2[2]);

            Console.WriteLine("-------------------------------------");
            int[] MeuArray3 = new int[] { 3, 30, 300 };
            Console.WriteLine(MeuArray3[0]);
            Console.WriteLine(MeuArray3[1]);
            Console.WriteLine(MeuArray3[2]);

            Console.WriteLine("\r\n");

            Console.WriteLine("-----Array de 2 dimensões-----");
            Console.WriteLine("Exemplo Código: string[,] MeuArray4 = new string[2, 3];");
            string[,] MeuArray4 = new string[2,3];
            MeuArray4[0, 0] = "1";
            MeuArray4[0, 1] = "2";
            MeuArray4[0, 2] = "3";
            MeuArray4[1, 0] = "11";
            MeuArray4[1, 1] = "12";
            MeuArray4[1, 2] = "13";
            Console.WriteLine(MeuArray4[0,0]);
            Console.WriteLine(MeuArray4[0,1]);
            Console.WriteLine(MeuArray4[0, 2]);
            Console.WriteLine(MeuArray4[1,0]);
            Console.WriteLine(MeuArray4[1,1]);
            Console.WriteLine(MeuArray4[1, 2]);

            Console.WriteLine("\r\n");

            Console.WriteLine("-----Outras maneiras de inicializar Array de 2 dimensões-----");
            Console.WriteLine("Exemplo Código: string[,] MeuArray5 = { { \"10\", \"20\", \"30\" }, { \"110\", \"120\", \"130\" } };");
            string[,] MeuArray5 = { { "10", "20", "30" }, { "110", "120", "130" } }; //Primeiro Exemplo
            Console.WriteLine(MeuArray5[0, 0]);
            Console.WriteLine(MeuArray5[0, 1]);
            Console.WriteLine(MeuArray5[0, 2]);
            Console.WriteLine(MeuArray5[1, 0]);
            Console.WriteLine(MeuArray5[1, 1]);
            Console.WriteLine(MeuArray5[1, 2]);
            Console.WriteLine("-------------------------------------");
            string[,] MeuArray6 = new string[,] { { "100", "200", "300" }, { "4000", "5000", "6000" } }; //Segundo Exemplo (+pratico)
            Console.WriteLine(MeuArray6[0, 0]);
            Console.WriteLine(MeuArray6[0, 1]);
            Console.WriteLine(MeuArray6[0, 2]);
            Console.WriteLine(MeuArray6[1, 0]);
            Console.WriteLine(MeuArray6[1, 1]);
            Console.WriteLine(MeuArray6[1, 2]);

            Console.WriteLine("\r\n");

            //Como saber o numero de elementos do array
            int tamanho1 = MeuArray6.GetLength(0);
            int tamanho2 = MeuArray6.GetLength(1);

            Console.WriteLine("A primeira dimensão do meu array 6 possui: " + tamanho1 + " Elementos");
            Console.WriteLine("A Segunda dimensão do meu array 6 possui: " + tamanho2 + " Elementos");

            Console.WriteLine("\r\n");

            //Array de 3 dimensões
            int[,,] MeuArray7 = new int[2, 2, 2];
            MeuArray7[0, 0, 0] = 500000;
            Console.WriteLine(MeuArray7[0, 0, 0]);

            Console.ReadKey();
        }
    }
}
