using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_Pizza
{
    class Grande : ITamano
    {
        public double Costo
        {
            get
            {
                return 4;
            }
        }

        public string Nombre
        {
            get
            {
                return "Grande";
            }
        }
    }
}
