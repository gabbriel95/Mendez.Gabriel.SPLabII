using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SinTintaException : Exception
    {
        public SinTintaException() : base("El fibron que intentas usar no tiene tinta suficiente") { }
        public SinTintaException(string message) : base(message) { }
    }
}
