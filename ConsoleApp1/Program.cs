using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador("Juanito", "12");

            Console.WriteLine("Jugador 1:");
            Console.WriteLine("Nombre: " + jugador1.Nombre);
            Console.WriteLine("Numero: " + jugador1.Numero);
            Console.WriteLine("Jugador 2:");
            Console.WriteLine("Nombre: " + jugador2.Nombre);
            Console.WriteLine("Numero: " + jugador2.Numero);



  

            Console.Read();
        }
    }
}
