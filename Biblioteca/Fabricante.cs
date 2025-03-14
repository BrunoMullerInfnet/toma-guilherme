using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Fabricante
    {
        private string _nome;
        private string _ramo;

        public Fabricante(string nome, string ramo)
        {
            _nome = nome;
            _ramo = ramo;
        }

        public string Nome
        {
            get { return _nome; }
        }

        public string Ramo
        {
            get { return _ramo; }
        }
    }
}
