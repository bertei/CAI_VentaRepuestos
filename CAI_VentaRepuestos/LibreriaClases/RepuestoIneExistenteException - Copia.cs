using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class RepuestoIneExistenteException : Exception //clase de particular de excepcion
    {
        public RepuestoIneExistenteException(string msg) : base(msg) //constructor que se le pasa un string
        {
        }
        

    }
}
