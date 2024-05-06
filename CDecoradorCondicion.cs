using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Metodologias
{
    public class CDecoradorCondicion : CADecoradorAlumno
    {
        IAlumno a;
        public CDecoradorCondicion(IAlumno adicional) : base(adicional)
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
            string condicion = " | DESAPROBADO";
            int calificacion = base.getCalificacion();
            if(calificacion >= 4 && calificacion < 7)
            {
                condicion = " | APROBADO"; 
            }
            if(calificacion >= 7)
            {
                condicion = " | PROMOCIÓN";
            }
            return msj + condicion;
        }
    }
}
