/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package conversionbase;

/**
 *
 * @author Jean Carlos
 */
public record ConversionRecord(String base, char[] digitos) {

    public String obtenerValor() {
        return new String(digitos);
    }

    public void mostrarResultado() {
        System.out.println(base() + ": " + obtenerValor());
    }
}
