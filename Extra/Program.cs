using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
           //  10, 5, 4, 7, 5, 8, 7, 7, 2, 9 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Dame un numero");
                int num = Convert.ToInt32(Console.ReadLine());
                lista.Add(num);
            }

            int ant = 0;//guardar el contador anterior
            int may = 0;//guarda el numero que mas se ha repetido

            foreach (int num1 in lista)
            {
                int contador = 0;
              
                foreach (int num2 in lista)
                {
                    if (num1 == num2)
                    {
                        contador++;
                    }
                }
                if (contador > ant)
                {
                    ant = contador;
                    may = num1;
                }
            }
            Console.WriteLine($"El numero ue mas se repite es {may}");
            Console.ReadLine();
        }
    }
}
