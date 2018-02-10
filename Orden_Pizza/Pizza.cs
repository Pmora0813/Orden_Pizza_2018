using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_Pizza
{
    abstract class Pizza
    {
        abstract public string nombre { get; }
        abstract public double costo();
    }
}
