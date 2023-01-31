using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrura_de_Decisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua Idade");
            UInt32 Idade = Convert.ToUInt32(Console.ReadLine());
            //if(se) ... else(Senao)..
            if (Idade >= 18/* Condicao booleana, que pode ser true ou false*/)
            {
                Console.WriteLine("Voce e maior de idade");
            }
            else//opcional
            {
                Console.WriteLine("voce nao e maior de idade!");
            }


            Console.WriteLine("Digite o seu salario");
            UInt32 Salario = Convert.ToUInt32(Console.ReadLine());

            //if ... else ... if...
            if (Salario < 1000 /* Condicao booleana, que pode ser true ou false*/) //Sempre precisa ter
            {
                Console.WriteLine("Voce ganha menos que um salario minimo");
            }
            else if (Salario < 2000 /* Condicao booleana, que pode ser true ou false*/) //Quantos a gente quiser 
            {
                Console.WriteLine("Voce ganha menos que dois salarios minimos");
            }
            else if (Salario < 5000/* Condicao booleana, que pode ser true ou false*/) //Quantos a gente quiser 
            {
                Console.WriteLine("Voce ganha menos que cinco salarios minimos");
            }
            else //Opicional
            {
                Console.WriteLine("Voce e rico!!!");
            }


            

            Console.WriteLine("Pressione uma tecla do seu teclado");
            char tecla = Console.ReadKey(true).KeyChar;
            //switch(comutador)
            switch (tecla/* variavel */)
            {
                case 'a':   /* valores */ //caso
                    Console.WriteLine("Voce pressionou a tecla: a");
                    break; //pare ou interrompa

                case 'b':   /* valores */ //caso
                    Console.WriteLine("Voce pressionou a tecla: b");
                    break;   //pare ou interrompa

                default:    //padrao - opicional
                    Console.WriteLine("Eu nao conheco essa tecla");
                    break;
            }
            Console.ReadKey();
        }   
    }
}
