using System;
using System.Collections.Generic;


namespace EstructuraApp
{
    // Definición del record struct
    public class Estudiante 
    { public string Nombre { get; set; } 
      public int Edad { get; set; }
      public double Promedio { get; set; }


        public Estudiante(string nombre, int edad, double promedio)
        {
            Nombre = nombre;
            Edad = edad;
            Promedio = promedio;
        }

        // Método mostrarInfo
        public void MostrarInfo()
        {
            Console.WriteLine($"Estudiante: {Nombre} | Edad: {Edad} | Promedio: {Promedio}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //Instancia

            var alumno1 = new Estudiante("Carlos Pérez", 19, 8.5);
            var alumno2 = new Estudiante("María López", 21, 6.5);
            var alumno3 = new Estudiante("Juan Torres", 20, 7.8);

            Estudiante[] listaAlumnos = { alumno1, alumno2, alumno3 };

            //Mostrar en pantalla.

            Console.WriteLine("--- Lista de Estudiantes ---");
            foreach (var estudiante in listaAlumnos)
            {
                Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, Promedio: {estudiante.Promedio}");

            }
        }
    }
}