using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_Pizza
{
    class Personal : ITamano
    {
        public double Costo
        {
            get
            {
                return 1;
            }
        }

        public string Nombre
        {
            get
            {
                return "Personal";
            }
        }
    }
}
