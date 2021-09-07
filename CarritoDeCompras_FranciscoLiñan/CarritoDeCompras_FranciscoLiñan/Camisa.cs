using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_FranciscoLiñan
{
    class Camisa : Producto
    {
        public override int GetPrecio()
        {
            return 1000;
        }

        public override int GetDescuento(int cantidad)
        {
            // Devuelve el tipo de descuento 0, 10 o 20
            //
            if (cantidad >= 3 && cantidad <= 5)
                return 10;
            if (cantidad > 5)
                return 20;

            return 0;
        }
    }
}
