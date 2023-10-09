//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{


    static void Main(string[] args)
    {
        Circulo C1 = new Circulo(34.53);
        Console.WriteLine(C1);

        Rectangulo R1 = new Rectangulo(34, 12);
        Console.WriteLine(R1);

        Triangulo_Equilatero TE1 = new Triangulo_Equilatero(84);
        Console.WriteLine(TE1);

        C1.Color = Color.FromArgb(245, 40, 145, 200);
        R1.Color = Color.FromArgb(35, 3, 15, 200);
        TE1.Color = Color.FromArgb(245, 40, 15, 200);

        List<Figura> listaDeFiguras = new List<Figura>
            {
                C1,
                R1,
                TE1,
            };

        CambiarColores(listaDeFiguras, "Green"); // Cambia el color de todas las figuras a verde

        foreach (Figura figura in listaDeFiguras)
        {
            Console.WriteLine($"Color de la figura: {figura.GetColorName()}");
        }

        double sumaDeAreas = SumarAreas(listaDeFiguras);
        Console.WriteLine($"Suma de las áreas de todas las figuras: {sumaDeAreas}");
    }

    // Método para sumar las áreas de todas las figuras en una lista
    static double SumarAreas(List<Figura> figuras)
    {
        double sumaDeAreas = 0.0;
        foreach (Figura figura in figuras)
        {
            sumaDeAreas += figura.GetArea();
        }
        return sumaDeAreas;
    }

    // Método para cambiar el color de todas las figuras en una lista
    static void CambiarColores(List<Figura> figuras, string nuevoColor)
    {
        foreach (Figura figura in figuras)
        {
            figura.CambiarColor(nuevoColor);
        }
    }


}

