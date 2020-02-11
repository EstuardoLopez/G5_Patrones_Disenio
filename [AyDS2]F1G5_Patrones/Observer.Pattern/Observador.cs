using _AyDS2_F1G5_Patrones.Strategy.Pattern;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _AyDS2_F1G5_Patrones.Observer.Pattern
{
    abstract class Observador : Form
    {
        protected Sujeto sujeto;
        public abstract void actualizar();
        public List<Jugador> jugadores;
        public TextBox txtResult;

        public Observador(string titulo)
        {
            this.Text = titulo;
            this.Size = new Size(400, 400);
            this.ControlBox = false;
            jugadores = new List<Jugador>();



            txtResult = new TextBox();
            txtResult.Name = "txtREsult";
            txtResult.Text = "";
            txtResult.Multiline = true;
            txtResult.ScrollBars  = ScrollBars.Vertical;
            txtResult.AcceptsReturn = true;
            txtResult.AcceptsTab = true;
            txtResult.WordWrap = true;
            txtResult.Location = new Point(40, 10);
            txtResult.Size = new Size(300, 300);
            this.Controls.Add(txtResult);
        }
    }
}
