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




    }

}