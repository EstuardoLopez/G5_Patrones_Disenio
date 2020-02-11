using _AyDS2_F1G5_Patrones.Observer.Pattern;
using _AyDS2_F1G5_Patrones.Strategy.Pattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _AyDS2_F1G5_Patrones
{
    public partial class Main : Form
    {
        VisorPorEquipo visorEquipo;
        VisorPorPosicion visorPosicion;
        Liga liga;
        Sujeto sujeto;
        public Main()
        {
            InitializeComponent();
            this.Text = "Menu Principal";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            liga = new Liga("Liga BBVA", "España");
            liga.agregarEquipo(new EquipoBarcelona());
            liga.agregarEquipo(new EquipoRealMadrid());

            sujeto = new Sujeto();
            visorEquipo = new VisorPorEquipo(sujeto);
            visorPosicion = new VisorPorPosicion(sujeto);
            sujeto.setLiga(liga);
            visorPosicion.Show();
            visorEquipo.Show();

            cbxEquipo.SelectedIndex = 0;
            cbxPosicion.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            //string dorsal = txtDorsal.Text;
            string equipo = cbxEquipo.Text; 
            string posicion = cbxPosicion.Text;

            var dorsal = String.IsNullOrEmpty(this.txtDorsal.Text) ? Convert.ToInt32("0") : Convert.ToInt32(this.txtDorsal.Text);


            if (equipo.ToUpper().Equals("BARCELONA"))
            {
                liga.equipos[0].AgregarJugador(posicion, nombre, 0, Convert.ToInt32(dorsal));
            }
            else
            {
                liga.equipos[1].AgregarJugador(posicion, nombre, 0, Convert.ToInt32(dorsal));
            }

            sujeto.setLiga(liga);
        }

        private void cbxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
