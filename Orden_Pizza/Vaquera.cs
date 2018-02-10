using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_Pizza
{
    class Vaquera : Pizza
    {
        public override string nombre
        {
            get
            {
                return "Vaquera";
            }
        }

        public override double costo()
        {
            return 3000;
        }
    }
}
