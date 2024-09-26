using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTienda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carrito carrito= new Carrito();
            
            //pedir productos hasta que el usuario quiera
            string nombre = "";
            int cantidad = 0;
            decimal precio = 0;
            Console.WriteLine("Ingresa nombre del producto");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa cantidad");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa precio");
            precio = Convert.ToDecimal(Console.ReadLine());

            //Forma 1 de crear instancia
            Producto prod = new Producto();
            prod.Nombre = nombre;
            prod.Cantidad = cantidad;
            prod.Precio = precio;
            carrito.AgregarProducto(prod);

            Caja caja = new Caja();
            caja.Cobrar(carrito);
            //Forma 2 de crear instancia
            //Producto prod2 = new Producto()
            //{
            //    Nombre = nombre,
            //    Cantidad = cantidad,
            //    Precio = precio
            //};
            carrito.MostrarCarrito();
            Console.ReadLine();
        }
    }
}
