public record ConversionRecord(String base, char[] digitos) {

    public String obtenerValor() {
        return new String(digitos);
    }

    public void mostrarResultado() {
        System.out.println(base() + ": " + obtenerValor());
    }
}
