using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        private void Problema1()
        {
            int x = 10;
            for (int i = 0; i < 5; i++)
            {
                x += i;
            }
        }

        private void Problema2()
        {
            int[] nums = { 2, 4, 6, 8 };
            Console.WriteLine(nums[1] + nums[3]);
        }

        private void Problema3()
        {
            for (int i = 0; i < 3; i++)
            {
                int result = i * 2;
            }
            Console.WriteLine(result);
        }

        private void Problema4()
        {
            List<int> numeros = new List<int> { 2, 4, 6, 8 };
            int resultado = SumarLista(numeros);
            Console.WriteLine("Resultado: " + resultado);
        }

        static int SumarLista(List<int> lista)
        {
            int suma = 0;
            foreach (int numero in lista)
            {
                suma = numero;
            }
            return suma;
        }

        private void Problema5()
        {
            List<int> precios = new List<int> { 5, 3, 4, 7 };
            int sumaIncorrecta = SumarPrecios(precios);
            Console.WriteLine($"Suma total: {sumaIncorrecta}");
        }

        static int SumarPrecios(List<int> precios)
        {
            int suma = 0;
            for (int i = 1; i < precios.Count; i++)
            {
                suma += suma + precios[i];
            }
            return suma;
        }

        private void Problema6()
        {
            List<int> numeros = new List<int> { 33, 37, 38, 43, 36 };

            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                total += numeros[1];
            }

            Console.WriteLine("Total acumulado: " + total);
        }
    }
}
