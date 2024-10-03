using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Caja
    {
        private static int NumCompra = 0;
        public int Numero { get; set; }
        private decimal Pagando { get; set; }
        public float Cambio { get; set; }
        private Carrito Cart { get; set; }
        private float Subtotal = 0;
        private float Total = 0;
        public Caja(int numero)
        {
            Numero = numero;
        }

        public void IngresarCarrito(Carrito cart)
        {
            Cart = cart;
            foreach (Articulo articulo in cart.Lista)
            {
                Subtotal += articulo.Precio * articulo.Cantidad;
            }
            MostrarTotales();
        }

        public void MostrarTotales()
        {
            float iva = Subtotal * .16f;
            Total = Subtotal + iva;

            Console.WriteLine($"Sub total : {Subtotal.ToString(".00")}");
            Console.WriteLine($"I.V.A. : {(Subtotal * .16).ToString(".00")}");
            Console.WriteLine($"Total : {Total.ToString(".00")}");

        }


        public void Cobrar()
        {
            Console.WriteLine("Ingrese cantidad a pagar");
            Pagando = Convert.ToDecimal(Console.ReadLine());
            Cambio = (float)Pagando - Total;
            Ticket ticket = new Ticket()
            {
                Lista = Cart.Lista,
                Total = Total,
                SubTotal = Subtotal,
                IVA = Subtotal * .16,
                Pagado = Pagando,
                Cambio = Cambio,
                Fecha = DateTime.Now,
                NumCompra = Numero,
            };
            ticket.Imprmir();
        }



    }
}
