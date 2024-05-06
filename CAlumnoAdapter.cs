using MetodologíasDeProgramaciónI;
using Practica1Metodologias;
using P3Metodologias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Metodologias
{
    public class CAlumnoAdapter : Student
    {
        IAlumno alumno;
        public CAlumnoAdapter(IAlumno alumno)
        {
            this.alumno = alumno;
        }

        public string getName()
        {
            return alumno.getNombre();
        }
        public string showResult()
        {
            return alumno.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return alumno.responderPregunta(question);
        }

        public void setScore(int score)
        {
            alumno.setCalificacion(score);
        }
        public bool equals(Student s)
        {
            CADecoradorAlumno ad = new CADecoradorAlumno(this.getAlumno());

            return ad.sosIgual((Practica1Metodologias.IComparable)((CAlumnoAdapter)s).getAlumno());
        }

        public bool lessThan(Student s)
        {
            return this.getAlumno().sosMenor((Practica1Metodologias.IComparable)((CAlumnoAdapter)s).getAlumno());
        }

        public bool greaterThan(Student s) 
        {
            return this.getAlumno().sosMayor((Practica1Metodologias.IComparable)((CAlumnoAdapter)s).getAlumno());
        }

        public IAlumno getAlumno()
        {
            return alumno;
        }
    }
}
