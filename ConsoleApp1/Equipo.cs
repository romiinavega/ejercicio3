using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Equipo
    {
            public string Nombre { get; set; }
            public string Origen { get; set; }
            public string Entrenador { get; set; }
            public List <Jugador>Jugadores { get; set; }


            public Equipo()
            {
                Nombre = "Equipo nuevo";
                Origen = "Sin asignar";
            Entrenador = "Sin entrenador";
            Jugadores = new List<Jugador>();


            }
            public Equipo(string nombre)
            {
                Nombre = nombre;
                Origen = "Sin asignar";
            Entrenador = "Sin entrenador";
            Jugadores = new List<Jugador>();
            }
        }
    }

