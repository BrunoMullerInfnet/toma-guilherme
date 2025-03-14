using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Fila<T>
    {
        private ArrayList array;

        public Fila()
        {
            array = new ArrayList();
        }

        public void ColocarNaFila(object pessoa)
        {
            array.Add(pessoa);
        }

        public void RetirarDaFila()
        {
            if (array.Count > 0)
            {
                if (array[0] is PessoaJuridica)
                {
                    Console.WriteLine($"Será removido:{((PessoaJuridica)array[0]).Cnpj}");
                }
                else
                {
                    Console.WriteLine($"Será removido:{((PessoaFisica)array[0]).Cpf}");
                }
                
                array.RemoveAt(0);
            }
        }

        public void ImprimirFila()
        {
            Console.WriteLine("Estão na Fila:");
            foreach (var fila in array)
            {
                Console.WriteLine(fila.ToString());
            }
        }
    }
}
