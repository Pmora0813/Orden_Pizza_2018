using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_Pizza
{
    class OrdenCompra_Factory
    {

        public static Orden_Compra CrearOrden(int cant, Pizza pizza, Pasta pasta, ITamano tamano)
        {
            Orden_Compra Orden = null;
            Orden = new Orden_Compra(cant, pizza, pasta, tamano);
            return Orden;
        }
    }
}
