using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_Pizza
{
    class Superma : Pizza
    {
        public override string nombre
        {
            get
            {
                return "Suprema";
            }
        }

        public override double costo()
        {
            return 2500;
        }
    }
}
