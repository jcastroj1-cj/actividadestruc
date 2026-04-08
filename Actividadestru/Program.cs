using System;

namespace EstructuraApp
{
    // Definición del record struct
    public record struct Estudiante(string Nombre, int Edad, double Promedio);

    class Program
    {
        static void Main(string[] args)
        {
            //Instancia

            var alumno1 = new Estudiante("Carlos Pérez", 19, 8.5);
            var alumno2 = new Estudiante("María López", 21, 9.2);
            var alumno3 = new Estudiante("Juan Torres", 20, 7.8);


        }
    }
}
