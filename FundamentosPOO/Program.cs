using FundamentosPOO.abstactas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FundamentosPOO
{
    internal class Program
    {

        //TAREA:
        //Investigar las clases abstractas con ejemplos
        static void Main(string[] args)
        {
            //Persona2 persona2 = 
            //    new Persona2("Juan",
            //    "juan@correo.com",
            //    1);
            //Console.ReadLine();
            //persona2.Nombre = "Juan Luis";
            //persona2.Email = "jluis@correo.com";
            //persona2.ImprimeNombre();
            //persona2.ImprimeEmail();
            //persona2.CambiarFecha(DateTime.Now);
            //persona2.ImprimeFecha();

            Cuadrado cuadrado = new Cuadrado()
            {
                MedidaLado = 5,
                UnidadMedida="metros"
            };
            cuadrado.MuestraArea();
            cuadrado.MuestraPerimetro();
            cuadrado.MedidaLado = 8;
            cuadrado.MuestraArea();
            //TAREA:
            //Hacer la implementacion para rectangulo, circulo, triangulo y poligono


            Console.ReadLine();
        }
    }
}
