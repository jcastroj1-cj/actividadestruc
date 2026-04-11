public class ConversionObj {
    private String base;
    private char[] digitos;

    public ConversionObj(String base, char[] digitos) {
        this.base = base;
        this.digitos = digitos;
    }

    public String obtenerValor() {
        return new String(digitos);
    }

    public void mostrarResultado() {
        System.out.println(base + ": " + obtenerValor());
    }
}
