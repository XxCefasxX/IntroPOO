using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona el articulo");
            Catalogo.MostrarCatalogo();
            int artID = Convert.ToInt32(Console.ReadLine());

            Articulo articuloSeleccionado = Catalogo.BuscarArticuloPorID(artID);
            Console.WriteLine("Cuantos va a comprar?");
            articuloSeleccionado.Cantidad = Convert.ToInt32(Console.ReadLine());
            //TAREA
            //Agregar el articulo al carrito
            Carrito cart = new Carrito();
            cart.AgregarArticulo(articuloSeleccionado);

            //ir a la caja
            Caja caja = new Caja(1);
            //Mostrar total
            caja.IngresarCarrito(cart);
            //Cobrar y Pagar
            //devolver cambio
            //imprmir ticket
            caja.Cobrar();



            Console.ReadLine();
        }
    }
}
