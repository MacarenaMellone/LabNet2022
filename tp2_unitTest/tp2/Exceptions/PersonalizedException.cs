using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Exceptions
{
    public class PersonalizedException : Exception 
    {
        public PersonalizedException() : base("Hoy no va a pasar"){
        }
    }
}
