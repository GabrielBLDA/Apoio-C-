using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_e_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando Uma Queue/"fila"
           Queue<string> FiladeNomes = new Queue<string>();

            //Adicionando Elementos
            FiladeNomes.Enqueue("Pato");
            FiladeNomes.Enqueue("Goin");
            FiladeNomes.Enqueue("Dom");
            FiladeNomes.Enqueue("Nando");
            FiladeNomes.Enqueue("Chimia");
            FiladeNomes.Enqueue("Rafa");
            FiladeNomes.Enqueue("Bilada");

            //Removendo Elementos (O primeiro que entra na fila é o primeiro que sair)
           string nomeRemovido = FiladeNomes.Dequeue();
           Console.WriteLine($"o nome removido foi: {nomeRemovido}");
           nomeRemovido = FiladeNomes.Dequeue();
           Console.WriteLine($"o nome removido foi: {nomeRemovido}");
           

            //Espiando Elemento (Espia sempre o primeiro item da lista)
            string  nomeEspiada= FiladeNomes.Peek();
            Console.WriteLine($"o nome Espiado foi: {nomeEspiada}");

            Console.WriteLine();//Corta linha

            //---------------------------STACK-------------------------

            //Declarando uma Stack / "Pilha"
            Stack<string> PilhaDeNomes = new Stack<string>();

            //Adicionando elementos na Stack / "Pilha"
            PilhaDeNomes.Push("Bilada");
            PilhaDeNomes.Push("Goin");
            PilhaDeNomes.Push("Chimia");
            PilhaDeNomes.Push("Dom O caça Dragões");
            PilhaDeNomes.Push("-Pato-");

            //Removendo elementos da stack / "Pilha"
            nomeRemovido = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido);
            nomeRemovido = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido);

            //Espiar elementos na stack/ "Pilha"
            nomeEspiada = PilhaDeNomes.Peek();
            Console.WriteLine(nomeEspiada);



            Console.ReadKey();

        }
    }
}
