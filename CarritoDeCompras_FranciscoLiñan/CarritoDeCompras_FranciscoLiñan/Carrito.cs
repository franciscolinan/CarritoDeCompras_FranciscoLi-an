﻿using System;
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
                total += producto.GetPrecio(0);
            });

            return total;
        }

        public int GetPrecioFinal()
        {
            int total = 0;

            this.productos_.ForEach((producto) =>
            {
                total += producto.GetPrecio(producto.GetDescuento(this.GetCantidad()));
            });

            return total;
        }

        public int GetDescuento()
        {
            int descuento = 0;

            this.productos_.ForEach((producto) =>
            {
                descuento += producto.GetDescuento(this.GetCantidad());
            });

            if (this.GetCantidad() > 0)
                return descuento / this.GetCantidad();

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
