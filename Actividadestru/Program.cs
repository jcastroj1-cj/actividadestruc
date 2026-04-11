
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
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        // Struct como elementos guardados en un arreglo
        ConversionStruct[] conversiones = new ConversionStruct[]
        {
            new ConversionStruct(Convert.ToString(n, 2).ToCharArray()),
            new ConversionStruct(Convert.ToString(n, 8).ToCharArray()),
            new ConversionStruct(Convert.ToString(n, 16).ToUpper().ToCharArray())
        };

        string[] nombres = { "Binario", "Octal", "Hexadecimal" };

        Console.WriteLine("\nResultados:");
        for (int i = 0; i < conversiones.Length; i++)
        {
            Console.WriteLine($"{nombres[i]}: {conversiones[i].ObtenerValor()}");
        }
    }
}



