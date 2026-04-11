/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package actividadestruc;

/**
 *
 * @author Jean Carlos
 */
public class Actividadestruc {

    record Estudiante(String nombre, int edad, double promedio) {}

    public static void main(String[] args) {

        // Guardar las 3 instancias en un arreglo
        Estudiante[] estudiantes = {
            new Estudiante("Ana García", 22, 9.5),
            new Estudiante("Luis Martínez", 18, 8.2),
            new Estudiante("Sofía Castro", 20, 7.9)
        };

        // Mostrar antes del cambio
        System.out.println("--- Antes del cambio ---");
        for (Estudiante e : estudiantes) {
            System.out.println("Nombre: " + e.nombre() + " | Edad: " + e.edad() + " | Promedio: " + e.promedio());
        }

        // Cambiar el promedio de Luis Martínez (índice 1)
        estudiantes[1] = new Estudiante(estudiantes[1].nombre(), estudiantes[1].edad(), 9.2);

        // Mostrar después del cambio
        System.out.println("\n--- Después del cambio ---");
        for (Estudiante e : estudiantes) {
            System.out.println("Nombre: " + e.nombre() + " | Edad: " + e.edad() + " | Promedio: " + e.promedio());
        }
    }
}