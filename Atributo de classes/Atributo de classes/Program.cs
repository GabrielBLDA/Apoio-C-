using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributo_de_classes
{

    public class Carro
    {
        //Como criar um atributo
        //MODIFICADOR_DE_ACESSO TIPO_DO_ATRIBUTO NOME_DO_ATRIBUTO

        //Modificadores
        //public (publico) - Todos podem acessar o nosso atributo/variavel
        //private (privado) - Somente a nossa clarsse podera acessar o atributo

        //Criando atributo
        public string marca;
        private double velocidade;


        public void ConfiguraVelocidade(double VelocidadeFinal)
        {
            velocidade = VelocidadeFinal;
            marca = "Fiat";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.marca = "Honda";
            //atributos privados só podem ser acessados dentro da nossa propria classe
            //meuCarro.velocidade = 100;
        }
    }
}
