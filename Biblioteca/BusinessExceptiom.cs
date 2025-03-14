using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class BusinessExcpetion : Exception
    {
        public BusinessExcpetion(string mensagem) : base(mensagem)
        {

        }
    }
}
