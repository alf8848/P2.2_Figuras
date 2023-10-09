using System.Drawing;

namespace P2_2_Figuras
{

    public class Triangulo_Equilatero : Figura
    {
        private double _lado;
        private Color green;

        public Triangulo_Equilatero(double lado)
        {
            this._lado = lado;
            _color = Color.Green;
        }

        public Triangulo_Equilatero(Color green)
        {
            this.green = green;
        }

        public Color Color { get; internal set; }

        public override double GetArea()
        {
            return (this._lado * this._lado); // Corregir el nombre de la variable 'vase' a 'basee'
        }

        public override string ToString()
        {
            return $@"
            Área: {this.GetArea()}
            Lado: {this._lado} 
            Color: Color[A=255, R=0, G=20, B=40]
            ";
        }

        internal override void CambiarColor(Color nuevoColor)
        {
            _color = nuevoColor;
        }
    }
}
