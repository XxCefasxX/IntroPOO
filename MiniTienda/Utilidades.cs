using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTienda
{
    class Utilidades
    {
        public static int contador =0;

        public static int suma(int a, int b)
        {
            contador++;
            return a + b;
        }
    }
}
