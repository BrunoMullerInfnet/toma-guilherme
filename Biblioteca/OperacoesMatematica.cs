using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class OperacoesMatematica
    {
        public void Multiplicar()
        {
            Console.Clear();

            //aplicando multiplicação entre dois valores        
            int a, b;

            Console.WriteLine("Digite o valor para a variável A:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor para a variável B:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O valor da Soma é:{a + b} ");

            Console.Read();
        }

        public void ParImpar()
        {
            try
            {
                Console.Clear();

                //aplicando multiplicação entre dois valores        
                int a;

                Console.WriteLine("Digite o valor para saber se é par ou impar:");

                a = Convert.ToInt32(Console.ReadLine());

                if (a % 2 == 0)
                    Console.WriteLine($"O numero {a} é par");
                else
                    Console.WriteLine($"O numero {a} é impar");

            }
            catch (Exception e)
            {
                Console.WriteLine("Valor inválido. " + e.Message);
                Console.Read();
            }
        }
    }
}
