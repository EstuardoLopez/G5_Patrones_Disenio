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
            //throw new NotImplementedException();
        }
    }
}
