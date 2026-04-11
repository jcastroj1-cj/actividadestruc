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

  // Definir el record
    record Estudiante(String nombre, int edad, double promedio) {}

    public static void main(String[] args) {

        // Crear instancia
        Estudiante e1 = new Estudiante("Ana García", 22, 9.5);

        // Mostrar información
        System.out.println("Nombre: " + e1.nombre());
        System.out.println("Edad: " + e1.edad());
        System.out.println("Promedio: " + e1.promedio());
    }
}
