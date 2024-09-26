using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTienda
{
    class Caja
    {
        public int Numero { get; set; }

        public Caja()
        {
            Numero = 0;
        }
        public Caja(int numero)
        {
            Numero = numero;
        }
        //mostrar la lista de productos y el total del carrito
        public void Cobrar(Carrito carrito)
        {

        }

        //crear metodo pagar
    }
}
