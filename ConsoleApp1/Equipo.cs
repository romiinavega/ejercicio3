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
            public string Jugadores { get; set; }

            public Equipo()
            {
                Nombre = "Pendiente";
                Origen = "Sin asignar";

            }
            public Equipo(string nombre, string matricula)
            {
                Nombre = nombre;
                Origen = matricula;
            }
        }
    }

