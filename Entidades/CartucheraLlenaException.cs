using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraLlenaException : Exception
    {
        public CartucheraLlenaException() : base("Lanzaste mi excepcion por defecto") { }
        public CartucheraLlenaException(string message) : base(message) { }
    }
}
