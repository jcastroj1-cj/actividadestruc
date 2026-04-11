using System;

public struct ConversionStruct
{
    public char[] Digitos;

    public ConversionStruct(char[] d)
    {
        Digitos = d;
    }

    public string ObtenerValor()
    {
        return new string(Digitos);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Número base 10: ");
        int n = int.Parse(Console.ReadLine());

        ConversionStruct bin = new ConversionStruct(Convert.ToString(n, 2).ToCharArray());
        ConversionStruct oct = new ConversionStruct(Convert.ToString(n, 8).ToCharArray());
        ConversionStruct hex = new ConversionStruct(Convert.ToString(n, 16).ToUpper().ToCharArray());

        Console.WriteLine("\nResultados:");
        Console.WriteLine("Binario: " + bin.ObtenerValor());
        Console.WriteLine("Octal: " + oct.ObtenerValor());
        Console.WriteLine("Hexadecimal: " + hex.ObtenerValor());
    }
}