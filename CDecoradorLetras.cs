using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Metodologias
{
    public class CDecoradorLetras : CADecoradorAlumno
    {
        IAlumno a;
        public CDecoradorLetras(IAlumno adicional) : base(adicional)
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
            string[] numeros = new string[]
            {
                "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"
            };

            return msj + " (" + numeros[base.getCalificacion()] + ")";
        }
    }
}
