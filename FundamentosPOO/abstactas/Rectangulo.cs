using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.abstactas
{
    internal class Rectangulo : Figura
    {
        public int MedidaLado1 { get; set; }
        public int MedidaLado2 { get; set; }

        public override void CalculaArea()
        {
            Area = MedidaLado1 * MedidaLado2;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = (MedidaLado1 * 2) + (MedidaLado2 * 2);
        }
    }
}
