using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Poo
{
    public class Omnibus : TransportePublico
    {
        public Omnibus (int pasajeros) : base (pasajeros){ }

        public override string Avanzar()
        {
            return string.Format("Avanza con {0} pasajeros", pasajeros);
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }

}
