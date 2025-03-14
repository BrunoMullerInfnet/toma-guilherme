using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PessoaJuridica : Pessoa
    {
        private string _razaoSocial;

        public PessoaJuridica(string cnpj, string razaoSocial) : base(cnpj)
        {
            _razaoSocial = razaoSocial;
        }

        public string Cnpj
        {
            get { return Documento; }
        }

        public string RazaoSocial
        {
            get { return _razaoSocial + " Top 5 Estrelas"; }
        }

        public double RetornarRendaDesconto(double renda)
        {
            return CalcularDesconto(renda);
        }

        private double CalcularDesconto(double renda)
        {
            double desconto = renda * 0.10;

            return (renda - desconto);
        }


    }
}
