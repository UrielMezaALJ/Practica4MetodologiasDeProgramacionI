using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1Metodologias;

namespace P3Metodologias
{
    public class CADecoradorAlumno : IAlumno, Practica1Metodologias.IComparable
    {
        IAlumno adicional;

        public virtual IAlumno getAlumno()
        {
            return adicional.getAlumno();
        }
        public CADecoradorAlumno(IAlumno adicional)
        {
            this.adicional = adicional;
        }

        public virtual string mostrarCalificacion()
        {
            return adicional.mostrarCalificacion();
        }
        public int getCalificacion()
        {
            return adicional.getCalificacion();
        }
        public int getLegajo()
        {
            return adicional.getLegajo();
        }

        public string getNombre()
        {
            return adicional.getNombre();
        }

        public int responderPregunta(int pregunta)
        {
            return adicional.responderPregunta(pregunta);
        }

        public void setCalificacion(int c)
        {
            adicional.setCalificacion(c);
        }

        public bool sosIgual(Practica1Metodologias.IComparable c)
        {
            return adicional.sosIgual(c);
        }

        public bool sosMenor(Practica1Metodologias.IComparable c)
        {
            return adicional.sosMenor(c);
        }

        public bool sosMayor(Practica1Metodologias.IComparable c)
        {
            return adicional.sosMayor(c);
        }
    }
}
