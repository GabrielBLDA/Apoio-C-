using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oitavo_Projeto
{
    internal class BaseDeDados
    {
        //atributo
        private List<CadastroPessoa> listaDePessoas; 
        
        //Métodos
        public void AdicionarPessoa(CadastroPessoa pPessoa)
        {
            listaDePessoas.Add(pPessoa);
        }

        public List<CadastroPessoa> PesquisaPessoaPorDoc(string pNumeroDoDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDoDocumento).ToList();
            if (listaDePessoasTemp.Count > 0) 
                return listaDePessoasTemp;
            else
                return null;
        }

        public List<CadastroPessoa> RemoverPessoaPorDoc(string pNumeroDoDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDoDocumento).ToList();
            if (listaDePessoasTemp.Count > 0) 
            {
                foreach(CadastroPessoa pessoa in listaDePessoasTemp)
                {
                    listaDePessoas.Remove(pessoa);
                }
                return listaDePessoasTemp;
            }
                
            else
                return null;
        }
        //Construtor
        public BaseDeDados()
        {
            listaDePessoas = new List<CadastroPessoa>();
        }
    }
}
