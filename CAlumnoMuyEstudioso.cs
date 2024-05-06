using Practica1Metodologias;
using System;
using P3Metodologias;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace P3Metodologias
{
    public class CAlumnoMuyEstudioso : Alumno
    {
        public CAlumnoMuyEstudioso(int legajo, double promedio, string nombre, int dni) : base(legajo, promedio, nombre, dni) { }

        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
