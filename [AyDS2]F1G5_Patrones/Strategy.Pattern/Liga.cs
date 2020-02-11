using _AyDS2_F1G5_Patrones.Observer.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _AyDS2_F1G5_Patrones.Strategy.Pattern
{
    class Liga 
    {
        public string nombre;
        public string pais;
        public List<Equipo> equipos;

        public Liga(string nombre, string pais)
        {
            equipos = new List<Equipo>();
            this.nombre =nombre;
            this.pais = pais;
            //equipos.Add(new EquipoBarcelona());
            //equipos.Add(new EquipoRealMadrid());
        }

        public void agregarEquipo(Equipo equipo)
        {
            this.equipos.Add(equipo);
        }
    }
}
