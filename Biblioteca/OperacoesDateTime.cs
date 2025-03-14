using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{   
    public class OperacoesDateTime
    {
        DateTime[] feriadosBR = new DateTime[]
        {
            new DateTime(2025,1,1),
            new DateTime(2025,4,21),
            new DateTime(2025,11,15)
        };

        DateTime[] feriadosUS = new DateTime[]
        {
            new DateTime(2025,04,07),
            new DateTime(2025,02,14),
            new DateTime(2025,10,31)
        };

        public void VerificaFeriado(DateTime data, CultureInfo culture)
        {
            string pais = culture.Name;

            switch (pais)
            {
                case "en-US":
                    if (CompararArrays(data, feriadosUS))
                    {
                        Console.WriteLine("Hoje é feriado nos EUA");
                    }

                    break;
                case "pt-BR":
                    if (CompararArrays(data, feriadosBR))
                    {
                        Console.WriteLine("Hoje é feriado no Brasil");
                    }
                    break;
                default:
                    Console.WriteLine("Pais inválido");
                    break;

            }
        }

        private bool CompararArrays(DateTime data, DateTime[] array)
        {
            foreach (var feriado in array)
            {
                if (feriado == DateTime.Now.Date)
                {
                    return true;
                }
            }

            return false;
        }

        public int CalcularIdade(DateTime dataNascimento)
        {
            int ano = dataNascimento.Year;

            int ano2 = DateTime.Now.Year;

            int idade = ano2 - ano;

            if (DateTime.Now < dataNascimento.AddYears(idade))
            {
                idade--; // idade = idade -1
            }

            return idade;
        }


    }
}
