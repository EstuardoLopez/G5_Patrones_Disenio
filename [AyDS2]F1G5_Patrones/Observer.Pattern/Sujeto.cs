using _AyDS2_F1G5_Patrones.Strategy.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _AyDS2_F1G5_Patrones.Observer.Pattern
{
    class Sujeto
    {
        private List<Observador> observadores = new List<Observador>();
        private Liga liga;

        public Liga getLiga()
        {
            return liga;
        }

        public void setLiga(Liga liga)
        {
            this.liga = liga;
            notificarTodosObservadores();
        }

        public void agregarObservador(Observador observador)
        {
            observadores.Add(observador);
        }

        public void notificarTodosObservadores()
        {
            foreach (Observador observador in observadores)
            {
                observador.actualizar();
            }
        }
    }
}
