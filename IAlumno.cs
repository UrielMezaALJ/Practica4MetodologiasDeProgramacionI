using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Metodologias
{
    public interface IAlumno 
    {
        IAlumno getAlumno();
        string mostrarCalificacion();
        string getNombre();
        int responderPregunta(int pregunta);
        void setCalificacion(int c);
        bool sosIgual(Practica1Metodologias.IComparable c);
        bool sosMenor(Practica1Metodologias.IComparable c);
        bool sosMayor(Practica1Metodologias.IComparable c);
        int getCalificacion();
        int getLegajo();
    }
}
