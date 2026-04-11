import java.util.Scanner;

public class ConversionBase {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Número base 10: ");

        try {
            int n = Integer.parseInt(scanner.nextLine());

            // Con Objetos
            ConversionObj[] conversiones = {
                new ConversionObj("Binario",     Integer.toBinaryString(n).toCharArray()),
                new ConversionObj("Octal",       Integer.toOctalString(n).toCharArray()),
                new ConversionObj("Hexadecimal", Integer.toHexString(n).toUpperCase().toCharArray())
            };

            System.out.println("\n--- Con Objetos ---");
            for (ConversionObj c : conversiones) {
                c.mostrarResultado();
            }

            // Con Record
            ConversionRecord[] conversionesRecord = {
                new ConversionRecord("Binario",     Integer.toBinaryString(n).toCharArray()),
                new ConversionRecord("Octal",       Integer.toOctalString(n).toCharArray()),
                new ConversionRecord("Hexadecimal", Integer.toHexString(n).toUpperCase().toCharArray())
            };

            System.out.println("\n--- Con Record ---");
            for (ConversionRecord c : conversionesRecord) {
                c.mostrarResultado();
            }

        } catch (NumberFormatException e) {
            System.out.println("Entrada inválida. Por favor ingrese un número entero.");
        }
    }
}
