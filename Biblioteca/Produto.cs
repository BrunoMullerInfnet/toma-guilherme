using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Produto
    {
        private string _nome;
        private decimal _valor;
        private short _quantidadeEstoque;

        public Produto(string nome, decimal valor, short quantidadeEstoque)
        {
            _nome = nome;
            _valor = valor;
            _quantidadeEstoque = quantidadeEstoque;
        }

        public void AdicionarEstoque(short quantidade)
        {
            _quantidadeEstoque += quantidade;
        }

        public void RemoverEstoque(short quantidade=1)
        {
            if (quantidade > _quantidadeEstoque 
                || _quantidadeEstoque <= 2)
            {
                throw new BusinessExcpetion("Atenção ao estoque");
            }
            _quantidadeEstoque -= quantidade;
        }

        public override string ToString()
        {
            return $" Produto {_nome}" +
                   $"tem o preço {_valor} " +
                   $"e quantidade {_quantidadeEstoque}";
        }

    }
}