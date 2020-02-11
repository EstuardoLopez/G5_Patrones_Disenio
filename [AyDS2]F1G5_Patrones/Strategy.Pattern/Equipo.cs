using _AyDS2_F1G5_Patrones.Factory.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _AyDS2_F1G5_Patrones.Strategy.Pattern
{
    abstract class Equipo
    {
        public string nombre;
        public string Estadio;
        private List<Jugador> plantilla;
        private JugadorFabrica fabrica; 

        public Equipo(string nombre, string estadio)
        {
            plantilla = new List<Jugador>();
            fabrica = new JugadorFabrica();
            this.nombre = nombre;
            this.Estadio = estadio;
        }

        public void AgregarJugador(string tipo, string nombre, int edad, int dorsal)
        {
            Jugador jugador = fabrica.crearJugador(tipo);
            jugador.Nombre = nombre;
            jugador.Edad = edad;
            jugador.tipo = tipo;
            jugador.dorsal = dorsal;
            jugador.tipo = tipo.ToUpper();
            plantilla.Add(jugador);
        }

        public List<Jugador> getPlantilla()
        {
            return this.plantilla;
        }

        public abstract void FilosofiaJuego();
    }
}
