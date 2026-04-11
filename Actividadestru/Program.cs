using System;

namespace ProyectoNotas
{
    // Definición de la clase en objeto
    public class Estudiante
    {
        public string Nombre { get; set; }

       
        public int[,] NotasMatriz = new int[3, 2];

        public Estudiante(string nombre)
        {
            Nombre = nombre;
        }

        public void MostrarPromedio()
        {
            Console.WriteLine($"\n--- Notas de {Nombre} ---");
            for (int i = 0; i < 3; i++)
            {
                double suma = NotasMatriz[i, 0] + NotasMatriz[i, 1];
                Console.WriteLine($"Materia {i + 1}: Promedio = {suma / 2}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Arreglo de Objetos
            Estudiante[] listaEstudiantes = new Estudiante[2];

            // Inicialización
            listaEstudiantes[0] = new Estudiante("Ana");
            listaEstudiantes[1] = new Estudiante("Luis");

            // Asignación de datos en la Matriz (Simulación)
            // Ana: Materia 0 (Mate), Parcial 0 = 85 | Parcial 1 = 90
            listaEstudiantes[0].NotasMatriz[0, 0] = 85;
            listaEstudiantes[0].NotasMatriz[0, 1] = 90;

            // Luis: Materia 1 (Programación), Parcial 0 = 70 | Parcial 1 = 100
            listaEstudiantes[1].NotasMatriz[1, 0] = 70;
            listaEstudiantes[1].NotasMatriz[1, 1] = 100;

            // Procesamiento
            foreach (var est in listaEstudiantes)
            {
                est.MostrarPromedio();
            }
        }
    }
}
