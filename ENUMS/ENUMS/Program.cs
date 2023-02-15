using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUMS
{
    internal class Program
    {
        enum NotasdeReal_e
        {
            NotaDe2 = 2,
            NotaDe5 = 5,
            NotaDe10 = 10
        }

        enum NotasDaProva_e
        {
            Nota0 = 0,
            Nota1,
            Nota2,
            Nota3,
            Nota4
        }
        static void Main(string[] args)
        {
            NotasdeReal_e minhaNota = NotasdeReal_e.NotaDe10;
            Console.WriteLine(minhaNota + " vale " + Convert.ToUInt32(minhaNota));
           
            NotasDaProva_e minhaNotaDaProva = NotasDaProva_e.Nota4;
            Console.WriteLine(minhaNotaDaProva + " vale " + Convert.ToUInt32(minhaNotaDaProva));

            Console.ReadKey();
        }
    }
}
