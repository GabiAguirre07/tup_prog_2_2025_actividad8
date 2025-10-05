using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    class PatenteNoValidaException : ApplicationException
    {
       public PatenteNoValidaException():base("Patente inválida") { }
       public PatenteNoValidaException(string message):base(message) { }
       public PatenteNoValidaException(string message, Exception inner):base(message, inner) { }

    }
}
