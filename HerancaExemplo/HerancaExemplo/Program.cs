using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro(4, 4);
            Avião meuAviao = new Avião(3, 2);
            meuCarro.ligar();
            meuAviao.ligar();
            meuCarro.Acelerar(100);
            meuAviao.Decolar(200, 1000);

            meuCarro.Brecar();
            meuAviao.Pousar();

            meuCarro.Desligar();
            meuAviao.Desligar();

            Console.ReadKey();
        }
    }
}
