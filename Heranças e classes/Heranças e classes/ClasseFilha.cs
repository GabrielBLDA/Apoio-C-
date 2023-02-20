using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças_e_classes
{
    internal class ClasseFilha: ClasseMae
    {

        public string AtributoDaFilha = "Atributo da Filha";
        public string PropriedadadeDaFilha
        {
            set;
            get;
        }
        public void MetodoDaClasseFilha()
        {
            
            Console.WriteLine("MetodoDaClasseFilha");
        }

        public ClasseFilha():base("INSERINDO O VALOR DO METODO CONSTRUTOR DA CLASSE MAE")
        {
            PropriedadadeDaFilha = "Propriedadade da Filha";
        }
    }
}
