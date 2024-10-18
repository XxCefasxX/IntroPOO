using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackathlon
{
    internal class Program
    {
        int intentosFallidos = 0;
        static void Main(string[] args)
        {
            //Juego del ahorcado
            //----------SI SE DESARROLLA INDIVIDUALMENTE-------------
            //Debera pedir una palabra al usuario para posteriormente ocultarla mostrando solo * en lugar de cada letra
            //Luego debra pedir una letra y si esta se encuentra en la palabra mostrar la letra en donde corresponde
            //Si la letra no se encuentra se añade un intento y el dibijo cambia
            //----------SI SE DESARROLLA EN EQUIPO-------------
            //Debera haber peviamente una lista de palabras de diferente tamaño
            //Preguntara al usuario de que nivel quiere el juego
            //Segun el nivel elegido el juego elegira una palabra aleatoriamente de la lista
            //por ejemplo si elige nivel facil debera ser una palabra de 4-6 letras, medio 7-10 dificl, 11 -15, experto 16 >
            //Mostrara la palabra mostrando solo * en lugar de cada letra
            //Luego debra pedir una letra y si esta se encuentra en la palabra mostrar la letra en donde corresponde
            //Si la letra no se encuentra se añade un intento y el dibijo cambia
        }

        public void DibujarPersona()
        {
            switch (intentosFallidos)
            {
                case 0:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("  =======");
                    break;
                case 1:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("  =======");
                    break;
                case 2:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("  =======");
                    break;
                case 3:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("  /|   |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("  =======");
                    break;
                case 4:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("  /|\\  |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("  =======");
                    break;
                case 5:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("  /|\\  |");
                    Console.WriteLine("  /    |");
                    Console.WriteLine("       |");
                    Console.WriteLine("  =======");
                    break;
                case 6:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("  /|\\  |");
                    Console.WriteLine("  / \\  |");
                    Console.WriteLine("       |");
                    Console.WriteLine("  =======");
                    break;
                default:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("  /|\\  |");
                    Console.WriteLine("  / \\  |");
                    Console.WriteLine("       |");
                    Console.WriteLine("  =======");
                    Console.WriteLine("¡Perdiste!");
                    break;
            }
        }
    }


       
    
}
