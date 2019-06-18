using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Jugador
    {
        public string Name { get; set; }
        public int Puntuacion { get; set; }
        public string Nivel { get; set; }

        public Jugador()
        {
        }

        public Jugador(Jugador Add)
        {
            Name = Add.Name;
            Puntuacion = Add.Puntuacion;
            Nivel = Add.Nivel;
        }
    }
}
