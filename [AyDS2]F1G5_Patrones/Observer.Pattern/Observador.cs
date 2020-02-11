﻿using _AyDS2_F1G5_Patrones.Strategy.Pattern;
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
            this.Width = 400;
            this.Height = 400;
            this.Text = titulo;
            jugadores = new List<Jugador>();



            txtResult = new TextBox();
            txtResult.Name = "txtREsult";
            txtResult.Text = "helloo";
            txtResult.Multiline = true;
            txtResult.Width = 300;
            txtResult.Height = 300;
            txtResult.Location = new Point(50, 50);
            this.Controls.Add(txtResult);
        }
    }
}
