using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno _Alumno = new Alumno();
            Profesor _Profesor = new Profesor();
            _Alumno.Edad = 17;
            _Alumno.Nombre = "JAMIE THOMAS";
            _Alumno.NoControl = 338;
            _Profesor.Edad = 23;
            _Profesor.Nombre = "Erick lml";
            _Profesor.Sueldos = 1;

            Console.WriteLine("La edad del alumno es {0} su nombre es {1} y Numero de control {2}",_Alumno.Edad,_Alumno.Nombre,_Alumno.NoControl);
            Console.WriteLine("La edad del profesor es {0} su nombre es {1} y sueldo {2}", _Profesor.Edad, _Profesor.Nombre, _Profesor.Sueldos);
            Console.ReadKey();
        }
    }
}
