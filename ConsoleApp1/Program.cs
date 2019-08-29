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
            List<Equipo> equipos =
                new List<Equipo>();
            Equipo yaquis = new Equipo("Yaquis");
            yaquis.Entrenador = "Pedro";
            yaquis.Origen = "Obregon";

            yaquis.Jugadores.Add(new Jugador("Jugador 1", 51));
            yaquis.Jugadores.Add(new Jugador("Jugador 2", 52));
            yaquis.Jugadores.Add(new Jugador("Jugador 3", 53));
            yaquis.Jugadores.Add(new Jugador("Jugador 4", 54));
            yaquis.Jugadores.Add(new Jugador("Jugador 5", 55));
            yaquis.Jugadores.Add(new Jugador("Jugador 6", 56));
            yaquis.Jugadores.Add(new Jugador("Jugador 7", 57));
            yaquis.Jugadores.Add(new Jugador("Jugador 8", 58));
            yaquis.Jugadores.Add(new Jugador("Jugador 9", 59));

            Equipo yankees = new Equipo("Yankees");
            yankees.Entrenador = "Juan";
            yankees.Origen = "NewYork";
            yankees.Jugadores.Add(new Jugador("Jugador 11", 4));
            yankees.Jugadores.Add(new Jugador("Jugador 12", 5));
            yankees.Jugadores.Add(new Jugador("Jugador 13", 45));
            yankees.Jugadores.Add(new Jugador("Jugador 14", 47));
            yankees.Jugadores.Add(new Jugador("Jugador 15", 48));
            yankees.Jugadores.Add(new Jugador("Jugador 16", 44));
            yankees.Jugadores.Add(new Jugador("Jugador 17", 41));
            yankees.Jugadores.Add(new Jugador("Jugador 18", 54));
            yankees.Jugadores.Add(new Jugador("Jugador 19", 84));

            equipos.Add(yaquis);
            equipos.Add(yankees);

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("*" + equipo.Nombre + " de " + equipo.Origen);
                foreach (Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("-" + jugador.Nombre + " " + jugador.Numero);
                }
            }







            /*
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador("Juanito", "12");

            Console.WriteLine("Jugador 1:");
            Console.WriteLine("Nombre: " + jugador1.Nombre);
            Console.WriteLine("Numero: " + jugador1.Numero);
            Console.WriteLine("Jugador 2:");
            Console.WriteLine("Nombre: " + jugador2.Nombre);
            Console.WriteLine("Numero: " + jugador2.Numero); */





            Console.Read();
        }
    }
}
