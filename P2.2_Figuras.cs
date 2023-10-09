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
        Circulo c1 = new Circulo(34.53);
        Console.WriteLine(c1);

        Rectangulo R1 = new Rectangulo(34, 12);
        Console.WriteLine(R1);

        Triangulo_Equilatero TE1 = new Triangulo_Equilatero(84);
        Console.WriteLine(TE1);

        // Crear una lista de figuras (rectángulos, círculos y triángulos equiláteros)
        List<Figura> listaDeFiguras = new List<Figura>
            {
                new Rectangulo(Color.Blue), // Rectángulo azul
                new Circulo(Color.Red), // Círculo rojo
                new Triangulo_Equilatero(Color.Green) // Triángulo equilátero verde
            };

        Color nuevoColor = Color.FromArgb(245, 40, 145, 200);

        foreach (Figura figura in listaDeFiguras)
        {
            figura.CambiarColor(nuevoColor);
        }

        foreach (Figura figura in listaDeFiguras)
        {
            Console.WriteLine($"Color de la figura: {figura.GetColorName()}");
        }
    }

}