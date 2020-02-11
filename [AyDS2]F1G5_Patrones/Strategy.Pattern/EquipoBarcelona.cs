using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _AyDS2_F1G5_Patrones.Strategy.Pattern
{
    class EquipoBarcelona : Equipo
    {
        public EquipoBarcelona() : base("FC Barcelona", "Camp Now")
        {
            AgregarJugador("Portero", "Marc-André ter Stegen", 27, 1);
            AgregarJugador("Portero", "Neto Murara", 30, 13);
            AgregarJugador("Defensa", "Nélson Semedo", 26, 2);
            AgregarJugador("Defensa", "Gerard Piqué", 33, 3);
            AgregarJugador("Defensa", "Clément Lenglet", 24, 15);
            AgregarJugador("Defensa", "Jordi Alba", 30, 18);
            AgregarJugador("Defensa", "Sergi Roberto", 28, 20);
            AgregarJugador("Defensa", "Samuel Umtiti", 26, 23);
            AgregarJugador("Defensa", "Junior Firpo", 23, 24);
            AgregarJugador("MedioCampista", "Ivan Rakitić", 31, 4);
            AgregarJugador("MedioCampista", "Sergio Busquets", 31, 5);
            AgregarJugador("MedioCampista", "Arthur Melo", 23, 8);
            AgregarJugador("MedioCampista", "Frenkie de Jong", 32, 21);
            AgregarJugador("MedioCampista", "Arturo Vidal", 33, 22);
            AgregarJugador("Delantero", "Luis Suárez", 33, 9);
            AgregarJugador("Delantero", "Lionel Messi", 32, 10);
            AgregarJugador("Delantero", "Ousmane Dembélé", 22, 11);
            AgregarJugador("Delantero", "Antoine Griezmann", 28, 17);
        }

        public override void FilosofiaJuego()
        {
            //Filosofia de juego: Posesion de la polota
        }
    }
}
