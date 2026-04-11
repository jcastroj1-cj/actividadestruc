
using System;

public struct ConversionRecord(String Base, char[] Digitos)
{
    public string ObtenerValor()

    {
        return new string(Digitos);
    }
    public void MostrarResultado()
    {
        Console.WriteLine($"{Base}: {ObtenerValor()}");
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

            // record como elementos guardados en un arreglo
            ConversionRecord[] conversiones = new ConversionRecord[]
                 {
                     new ConversionRecord("Binario", Convert.ToString(n, 2).ToCharArray()),
                     new ConversionRecord("Octal", Convert.ToString(n, 8).ToCharArray()),
                     new ConversionRecord("Hexadecimal", Convert.ToString(n, 16).ToUpper().ToCharArray())
                 };

            Console.WriteLine("\nResultados:");
            foreach (var conversion in conversiones)
            {
                conversion.MostrarResultado();
            }
        }

    }
}



