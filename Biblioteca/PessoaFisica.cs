using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PessoaFisica : Pessoa
    {
        private string _cpf;
        private string _nome;
        private DateTime? _dataNascimento;

        public string Cpf
        {
            get { return Documento; }
        }

        //Construtor com parametros
        public PessoaFisica(string cpf,
                            string Nome,
                            DateTime? DataNascimento) : base(cpf)
        {
            _cpf = cpf;
            _nome = Nome;
            _dataNascimento = DataNascimento;
        }

        public void TrocarNome(string novoNome)
        {
            _nome = novoNome;
        }

        public string CalcularTempoVida(DateTime dataNascimento)
        {
            TimeSpan diferenca = DateTime.Now.Subtract(dataNascimento);
            int ano = diferenca.Days / 365;
            int mes = diferenca.Days % 365 / 30;
            int dias = diferenca.Days % 365 % 30;

            return $"Tempo de existencia - Anos:{ano}, Meses{mes}, dias {dias}  ";
        }

    }
}
