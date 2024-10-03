using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    //• Lista de articulos
    //• IVA
    //• Total, Pagado y cambio
    //• Fecha
    //• Numero de compra
    class Ticket
    {
        public List<Articulo> Lista { get; set; }
        public float Total { get; set; }
        public float  SubTotal { get; set; }
        public decimal Pagado { get; set; } 
        public float Cambio { get; set; }
        public DateTime Fecha { get; set; }
        public int NumCompra { get; set; }
        public double IVA { get; set; }

        public void Imprmir()
        {
            Console.Clear();
            NumCompra++;
            //• Fecha
            DateTime fecha = DateTime.Now;
            Console.WriteLine($"Fecha: {fecha}");
            //• Numero de caja
            Console.WriteLine($"Caja: {NumCompra}");
            //• Numero de compra
            Console.WriteLine($"N Compra: {NumCompra}");
            //• Lista de articulos
            foreach (Articulo articulo in Lista)
            {
                string totalArt = (articulo.Precio * articulo.Cantidad).ToString(".00");
                Console.WriteLine($"{articulo.Nombre} - {articulo.Precio} - {articulo.Cantidad} - {totalArt}");
            }
            //• IVA
            //• Total, Pagado y cambio
            Console.WriteLine($"Sub total : {Total.ToString(".00")}");
            Console.WriteLine($"I.V.A. : {(SubTotal * .16).ToString(".00")}");
            Console.WriteLine($"Total : {Total.ToString(".00")}");
            Console.WriteLine($"Pagado:{Pagado.ToString(".00")}");
            Console.WriteLine($"Cambio:{Cambio.ToString(".00")}");

        }
    }
}
