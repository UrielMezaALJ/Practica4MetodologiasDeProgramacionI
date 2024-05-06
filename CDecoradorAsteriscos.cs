using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Metodologias
{
    public class CDecoradorAsteriscos : CADecoradorAlumno
    {
        IAlumno a;
        public CDecoradorAsteriscos(IAlumno adicional) : base(adicional)
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
            string lineaHorizontal = new string('*', msj.Length + 4); 
            return $"{lineaHorizontal}\n* {msj} *\n{lineaHorizontal}";
            
        }
    }
}
