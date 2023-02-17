using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MODIFICADOR_DE_ACESSO class NOME_DA_CLASSE {}

//Modificadores de acesso 
//internal (interno) - A nossa classe só poderá ser acessadaa pelo nosso assembly
//public (público) - O uso da nossa classe é livre
//private (privado) - A nossa classe só podera ser acessada internamente ao bloco de código que a criou

namespace Criando_Classes
{
    internal class Carro_Internal
    {

    }

    public class Carro_public
    {

    }

    
    internal class Program
    {
        //só é possivel criar classes privadas dentro de outras classes 
        static void Main(string[] args)
        {
        }
    }
}
