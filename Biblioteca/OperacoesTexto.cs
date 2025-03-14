using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class OperacoesTexto
    {
        public void ImprimirMaiusculo(string valor)
        {
            Console.WriteLine($"Nome em maiusculo: {valor.ToUpper()}");
        }

        public void ImprimirMinusculo(string valor)
        {
            Console.WriteLine($"Nome em maiusculo: {valor.ToLower()}");
        }

        public void ImprimirArray(string valor)
        {
            string[] array = valor.Split(' ');

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Indice {i}: {array[i]} ");
            }
        }

        public void ImprimirNomeSobreNome(string valor)
        {
            Console.WriteLine("Trabalhando com substring - Pegando Nome:");

            Console.WriteLine(valor.Substring(0, valor.IndexOf(" ")));

            Console.WriteLine("Trabalhando com substring - Pegando Sobrenome:");

            valor = valor.Substring(valor.IndexOf(" "));

            Console.WriteLine("SobreNome: " + valor);
        }

        /*

        public void Imprimir(string valor, bool minusculo)
        {
            string retorno;
           
            if(minusculo)
                retorno = valor.ToLower();
            else
                retorno = valor.ToUpper();

            Console.WriteLine($"Nome: {retorno}");
        }
        */
    }
}
