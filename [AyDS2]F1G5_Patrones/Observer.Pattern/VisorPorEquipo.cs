using _AyDS2_F1G5_Patrones.Strategy.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _AyDS2_F1G5_Patrones.Observer.Pattern
{
    class VisorPorEquipo : Observador
    {
        public VisorPorEquipo(Sujeto sujeto): base("Reporte por Equipo")
        {
            this.sujeto = sujeto;
            this.sujeto.agregarObservador(this);
        }

        public override void actualizar()
        {
            txtResult.Text = string.Empty;

            String msj = "Equipo de la Liga: " + sujeto.getLiga().nombre;
            txtResult.AppendText(msj);
            txtResult.AppendText(Environment.NewLine);
            foreach (Equipo equipo in sujeto.getLiga().equipos)
            {
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText(equipo.nombre);
                txtResult.AppendText(Environment.NewLine);
                foreach (Jugador jugador in equipo.getPlantilla()) {
                    txtResult.AppendText("     " + jugador.dorsal + ". " + jugador.Nombre);
                    txtResult.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
