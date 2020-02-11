using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _AyDS2_F1G5_Patrones.Strategy.Pattern;

namespace _AyDS2_F1G5_Patrones.Factory.Pattern
{
    class JugadorFabrica
    {
        public Jugador crearJugador(string tipo)
        {
            Jugador result = null;
            switch (tipo.ToUpper())
            {
                case "PORTERO":
                    result = new JugadorPortero();
                    break;
                case "DEFENSA":
                    result = new JugadorDefensa();
                    break;
                case "MEDIOCAMPISTA":
                    result = new JugadorMedioCampo();
                    break;
                case "DELANTERO":
                    result = new JugadorDelantero();
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }
    }
}
