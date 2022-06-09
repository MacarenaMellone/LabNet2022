using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4.EF.Common
{
    public class CustomException : Exception
    {
        public CustomException() : base("No se puede eliminar esta categoria, esta asociada a productos")
        {
        }
    }
}
