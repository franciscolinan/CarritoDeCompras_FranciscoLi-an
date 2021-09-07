using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_FranciscoLiñan
{
    // Clase abstracta
    abstract class Producto
    {
        public abstract int GetPrecio(int descuento);
        public abstract int GetDescuento(int cantidad);
    }
}
