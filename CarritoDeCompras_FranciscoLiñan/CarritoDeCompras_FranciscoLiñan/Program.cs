using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_FranciscoLiñan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opté por crear los miembros y metodos de la clase Shopping estáticos 
            // y los de la clase Carrito no estáticos
            //
            
            while (!Shopping.ImprimirMenu()) { }

            Console.ReadLine();
        }
    }
}
