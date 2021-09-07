using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_FranciscoLiñan
{
    class Carrito
    {
        // Miembros de la clase
        //
        private List<Producto> productos_ = new List<Producto>(); 

        // Métodos de la clase
        public int GetCantidad()
        {
            return this.productos_.Count();
        }

        public int GetTotalSinDesc()
        {
            int total = 0;

            this.productos_.ForEach((producto) =>
            {
                total += producto.GetPrecio();
            });

            return total;
        }

        public int GetPrecioFinal()
        {
            if (this.GetCantidad() > 0)
                return this.GetTotalSinDesc() - (this.GetTotalSinDesc() * this.productos_[0].GetDescuento(this.GetCantidad()) / 100);

            return 0;
        }

        public int GetDescuento()
        {
            if (this.GetCantidad() > 0)
                return this.productos_[0].GetDescuento(this.GetCantidad());

            return 0;
        }

        public void AgregarProducto(Producto producto)
        {
            this.productos_.Add(producto);
        }

        public bool QuitarProducto()
        {
            // Devuelve true si se pudo eliminar una camisa
            // caso contrario false
            //
            if (this.GetCantidad() > 0)
            {
                this.productos_.RemoveAt(0);
                return true;
            }

            return false;
        }
    }
}
