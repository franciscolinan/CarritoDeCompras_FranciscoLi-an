using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_FranciscoLiñan
{
    class Shopping
    {
        static Carrito carrito_ = new Carrito();

        static public bool ImprimirMenu()
        {
            // Devuelve true mientras el usuario no haya finalizado
            //

            // Imprimir menú
            Console.WriteLine("SHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Menú principal:");
            Console.WriteLine("1- Agregar camisa al carro de compras");
            Console.WriteLine("2- Eliminar camisa del carro de compras");
            Console.WriteLine("3- Salir");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("        -    Cantidad de camisas en el carro de compras: " + carrito_.GetCantidad());

            if (carrito_.GetCantidad() > 0)
                Console.WriteLine("        -    Precio unitario: " + carrito_.GetTotalSinDesc() / carrito_.GetCantidad());
            else
                Console.WriteLine("        -    Precio unitario: 0");


            Console.WriteLine("        -    Precio total sin descuento: " + carrito_.GetTotalSinDesc());
            Console.WriteLine("        -    Tipo de descuento aplicado: " + carrito_.GetDescuento() + "%");
            Console.WriteLine("        -    Precio final con descuento: " + carrito_.GetPrecioFinal());
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Ingrese una opción del menú: ");

            // Leer input del usuario
            //
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    carrito_.AgregarProducto(new Camisa());
                    break;
                case 2:
                    carrito_.QuitarProducto();
                    break;
                case 3:
                    // Limpiar pantalla
                    Console.Clear();

                    Console.WriteLine("¿Está seguro que desea salir? S/ N");

                    if (Console.ReadLine() == "S")
                        return true;

                    break;
                default:
                    break;
            }

            // Limpiar pantalla
            Console.Clear();

            return false;
        }
    }
}
