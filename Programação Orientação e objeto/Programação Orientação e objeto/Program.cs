using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programação_Orientação_e_objeto
{
      public class Carro
    {
        //Atributos ou variaveis
        private string marca;
        private string modelo;
        private UInt32 velocidade;
        private bool carroLigado;

        //Propriedades
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public UInt32 Velocidade
        {
            get { return velocidade; }
            set { Velocidade = value; }
        }

        public bool CarroLigado
        {
            get { return carroLigado; }
            set { carroLigado = value; }
        }

        //metodos
        public void LigarCarro()
        {
            carroLigado = true;
            Console.WriteLine($"Ligando o carro da {marca} e do modelo {modelo}");
        }

        public void DesligarCarro()
        {
            carroLigado = false;
            Console.WriteLine($"Desligando o carro da {marca} e do modelo {modelo}");
        }

        public void AcelerarCarro(UInt32 velocidadeFinal)
        {
            if (carroLigado == true)
            {

            }
            velocidade = velocidadeFinal;
            Console.WriteLine($"A velocidade do carro da marca {marca} e do modelo {modelo} é: {velocidade}");
        }

        public void PararCarro()
        {
            velocidade = 0;
            Console.WriteLine($"o carro da marca {marca} e do modelo {modelo} esta parado");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
