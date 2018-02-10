using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_Pizza
{
    class Mediana : ITamano
    {
        public double Costo
        {
            get
            {
                return 2;
            }
        }

        public string Nombre
        {
            get
            {
                return "Mediana";
            }
        }
    }
}
