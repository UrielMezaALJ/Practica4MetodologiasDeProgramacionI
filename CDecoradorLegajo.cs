using Practica1Metodologias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Metodologias
{
    public class CDecoradorLegajo : CADecoradorAlumno
    {
        IAlumno a;
        public CDecoradorLegajo(IAlumno adicional) : base(adicional)
        {
            this.a = adicional;
        }

        public override IAlumno getAlumno()
        {
            return base.getAlumno();
        }
       

        public override string mostrarCalificacion()
        {
            string msj = base.mostrarCalificacion();

            return msj + " | Legajo: " + base.getLegajo();
        }
    }
}
