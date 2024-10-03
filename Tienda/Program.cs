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
            while (true)
            {
                bool Agregar = true;
                Carrito cart = new Carrito();
                while (Agregar)
                {
                    Console.WriteLine("Selecciona el articulo");
                    Console.WriteLine("0 - Ir a caja");
                    Catalogo.MostrarCatalogo();
                    int artID = Convert.ToInt32(Console.ReadLine());
                    if (artID > 0)
                    {
                        Articulo articuloSeleccionado = Catalogo.BuscarArticuloPorID(artID);
                        Console.WriteLine("Cuantos va a comprar?");
                        articuloSeleccionado.Cantidad = Convert.ToInt32(Console.ReadLine());
                        //TAREA
                        //Agregar el articulo al carrito
                        cart.AgregarArticulo(articuloSeleccionado);
                        Console.Clear();
                    }
                    else
                    {
                        Agregar = false;
                    }


                }


                //ir a la caja
                Caja caja = new Caja(1);
                //Mostrar total
                caja.IngresarCarrito(cart);
                //Cobrar y Pagar
                //devolver cambio
                //imprmir ticket
                caja.Cobrar();


                Console.WriteLine("\n\n\n\nInciar nueva compra...");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
