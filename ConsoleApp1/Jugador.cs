using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugador()
        {
            Nombre = "Pendiente";
            Numero = "Sin asignar";

        }
        public Jugador(string nombre, string matricula)
        {
            Nombre = nombre;
            Numero = matricula;
        }
    }
}
