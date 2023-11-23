using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ElementoNoEncontrado : Exception
    {
        public ElementoNoEncontrado(string? message) : base(message)
        {
        }

        public ElementoNoEncontrado(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
