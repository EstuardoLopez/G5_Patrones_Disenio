using _AyDS2_F1G5_Patrones.Strategy.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _AyDS2_F1G5_Patrones.Observer.Pattern
{
    class VisorPorPosicion : Observador
    {
        public VisorPorPosicion(Sujeto sujeto): base("Reporte por posicion")
        {
            this.sujeto = sujeto;
            this.sujeto.agregarObservador(this);
        }

        public override void actualizar()
        {
            txtResult.Text = string.Empty;

            String msj = "Jugadores de la Liga: " + sujeto.getLiga().nombre + Environment.NewLine + Environment.NewLine;
            string porteros = "Portero:" + Environment.NewLine;
            string defensas = "Defensa:" + Environment.NewLine;
            string medios = "Medio campistas:" + Environment.NewLine;
            string delanteros = "delanteros:" + Environment.NewLine;

            txtResult.AppendText(msj);
            txtResult.AppendText(Environment.NewLine);
            foreach (Equipo equipo in sujeto.getLiga().equipos)
            {
                foreach (Jugador jugador in equipo.getPlantilla())
                {
                    msj = "     " + jugador.dorsal + ". " + jugador.Nombre + "  ->  " + equipo.nombre + Environment.NewLine; 
                    switch (jugador.tipo.ToUpper())
                    {
                        case "PORTERO":
                            porteros += msj;
                            break;
                        case "DEFENSA":
                            defensas += msj;
                            break;
                        case "MEDIOCAMPISTA":
                            medios += msj;
                            break;
                        case "DELANTERO":
                            delanteros += msj;
                            break;
                        default:
                            msj += ""; 
                            break;
                    }
                }
            }

            txtResult.AppendText(porteros + Environment.NewLine);
            txtResult.AppendText(defensas + Environment.NewLine);
            txtResult.AppendText(medios + Environment.NewLine);
            txtResult.AppendText(delanteros + Environment.NewLine);
        }
    }
}
