
using System;

public struct ConversionObj
{
    public char[] Digitos;
    public string Base;

    //Contructor
    public ConversionObj(char[] d, string nombreBase)
    {
        Digitos = d;
        Base = nombreBase;
    }

    //Metodo
    public string ObtenerValor()
    {
        return new string(Digitos);
    }

    public void MostrarResultado()
    {
        Console.WriteLine($"Base: {ObtenerValor ()}");
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

        // Objeto como elementos guardados en un arreglo
        ConversionObj[] conversiones = new ConversionObj[]
        {
            new ConversionObj(Convert.ToString(n, 2).ToCharArray(), "Binario"),
            new ConversionObj(Convert.ToString(n, 8).ToCharArray(), "Octal"),
            new ConversionObj(Convert.ToString(n, 16).ToUpper().ToCharArray(), "Hexadecimal")
        };

        string[] nombres = { "Binario", "Octal", "Hexadecimal" };

        Console.WriteLine("\nResultados:");
        foreach (var conversion in conversiones)
        {
           conversion.MostrarResultado();
        }
    }
}



