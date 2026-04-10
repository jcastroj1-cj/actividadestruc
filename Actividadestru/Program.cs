using System;

namespace EstructuraApp
{
    // Definición del record struct
    public record struct 
        Estudiante(string Nombre, int Edad, double Promedio);

    class Program
    {
        static void Main(string[] args)
        {
            //Instancia

            var alumno1 = new Estudiante("Carlos Pérez", 19, 8.5);
            var alumno2 = new Estudiante("María López", 21, 9.2);
            var alumno3 = new Estudiante("Juan Torres", 20, 7.8);

            Estudiante[] listaAlumnos = { alumno1, alumno2, alumno3 };

            //Mostrar en pantalla.

            Console.WriteLine($"{alumno1.Nombre} tiene un promedio de {alumno1.Promedio}");
            Console.WriteLine($"{alumno2.Nombre} tiene un promedio de {alumno2.Promedio}");
            Console.WriteLine($"{alumno3.Nombre} tiene un promedio de {alumno3.Promedio}");
        }
    }
}
