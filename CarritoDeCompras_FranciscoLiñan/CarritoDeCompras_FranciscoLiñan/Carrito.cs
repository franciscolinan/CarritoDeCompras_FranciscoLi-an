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
        private int cantidad_camisas_ = 0;
        private const int precio_unitario_ = 1000;

        // Métodos de la clase
        public int GetCantidadCamisas()
        {
            return this.cantidad_camisas_;
        }

        public int GetPrecioUnitario()
        {
            return precio_unitario_;
        }

        public int GetDescuento()
        {
            // Devuelve el tipo de descuento 0, 10 o 20
            //
            if (this.cantidad_camisas_ >= 3 && this.cantidad_camisas_ <= 5)
                return 10;
            if (this.cantidad_camisas_ > 5)
                return 20;

            return 0;
        }

        public int GetTotalSinDesc()
        {
            return this.cantidad_camisas_ * precio_unitario_;
        }

        public int GetPrecioFinal()
        {
            return this.GetTotalSinDesc() - (GetTotalSinDesc() * GetDescuento() / 100);
        }

        public void AgregarCamisa()
        {
            ++this.cantidad_camisas_;
        }

        public bool QuitarCamisa()
        {
            // Devuelve true si se pudo eliminar una camisa
            // caso contrario false
            //
            if (this.cantidad_camisas_ > 0)
            {
                --this.cantidad_camisas_;
                return true;
            }

            return false;
        }
    }
}
