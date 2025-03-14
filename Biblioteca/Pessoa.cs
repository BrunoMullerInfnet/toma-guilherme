using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pessoa
    {
        private string _documento; //cnpj ou cpf

        public string Documento //propriedade 
        {
            get { return _documento; }
        }

        public Pessoa(string documento) //construtor
        {
            _documento = documento;
        }
    }
}
