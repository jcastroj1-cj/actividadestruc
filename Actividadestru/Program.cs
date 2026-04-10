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
            // las 3 instancias y almacenarlas en un arreglo
            Estudiante[] alumnos = new Estudiante[]
            {
                new Estudiante("Ana García", 22, 9.5),
                new Estudiante("Luis Martínez", 18, 8.2),
                new Estudiante("Sofía Castro", 20, 7.9)
            };

            //  se llama al método MostrarInfo para cada objeto
            Console.WriteLine("--- Información de Alumnos ---");
            foreach (var alumno in alumnos)
            {
                alumno.MostrarInfo();
            }
        }
    }
}