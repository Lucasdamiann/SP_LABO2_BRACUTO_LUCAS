using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CantidadCaracteresInvalidaException : Exception
    {
        public CantidadCaracteresInvalidaException(string? message) : base(message)
        {
        }

        public CantidadCaracteresInvalidaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
