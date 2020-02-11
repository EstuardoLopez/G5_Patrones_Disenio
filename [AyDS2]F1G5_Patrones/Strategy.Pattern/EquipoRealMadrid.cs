using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _AyDS2_F1G5_Patrones.Strategy.Pattern
{
    class EquipoRealMadrid : Equipo
    {
        public EquipoRealMadrid() : base("Real Madrid FC","Santiago Bernabeu")
        {
            AgregarJugador("Portero", "Areola", 27, 1);
            AgregarJugador("Portero", "Courtois", 30, 13);
            AgregarJugador("Defensa", "Carvajal", 26, 2);
            AgregarJugador("Defensa", "E. Militão", 33, 3);
            AgregarJugador("Defensa", "Sergio Ramos", 24, 4);
            AgregarJugador("Defensa", "R. Varane", 30, 5);
            AgregarJugador("Defensa", "Nacho", 28, 6);
            AgregarJugador("Defensa", "Marcelo", 26, 12);
            AgregarJugador("Defensa", "F. Mendy", 23, 23);
            AgregarJugador("MedioCampista", "Kroos", 31, 8);
            AgregarJugador("MedioCampista", "Modric", 31, 10);
            AgregarJugador("MedioCampista", "Casemiro", 23, 14);
            AgregarJugador("MedioCampista", "Valverde", 32, 15);
            AgregarJugador("MedioCampista", "James Rodríguez", 33, 16);
            AgregarJugador("MedioCampista", "Isco", 33, 22);
            AgregarJugador("Delantero", "Hazard", 32, 7);
            AgregarJugador("Delantero", "Benzema", 22, 9);
            AgregarJugador("Delantero", "Bale", 28, 11);
            AgregarJugador("Delantero", "Vinicius Jr.", 28, 25);
        }

        public override void FilosofiaJuego()
        {
            //Filosofia de juego 
        }
    }
}
