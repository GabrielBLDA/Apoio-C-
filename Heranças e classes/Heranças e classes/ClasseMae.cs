using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças_e_classes
{

    //Modificadores de acesso
    //public - todo mundo tem acesso (classes filhas e externamente)
    //private - somente a propria classe tem acesso (nem as filhas nem externamente conseguiremos acessar)
    //protected - sómente poderá ser acessado pela classe filha e pela propria classe (externamente nao podera ser acessado)
    internal class ClasseMae
    {
        public string AtributoDaMae = "Atributo da mãe";
        public string PropriedadeDaMae
        {
            set;
            get;
        }
        public void MetodoDaClasseMae()
        {
            Console.WriteLine("MetodoDaClasseMae");
        }

        public ClasseMae(string pPropriedadeDaMae)
        {
            PropriedadeDaMae = pPropriedadeDaMae;
        }
    }
}
