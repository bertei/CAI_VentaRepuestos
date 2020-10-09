using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class CategoriaInexistenteException : Exception //clase de particular de excepcion
    {
        public CategoriaInexistenteException(string msg) : base(msg) //constructor que se le pasa un string
        {
        }
        

    }
}
