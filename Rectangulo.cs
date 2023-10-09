using System.Drawing;

namespace P2_2_Figuras
{
    public class Rectangulo : Figura
    {
        private double _basee;
        private double _altura;
        private Color blue;

        public Rectangulo(Color blue)
        {
            this.blue = blue;
        }

        public Rectangulo(double basee, double altura)
        {
            this._basee = basee;
            this._altura = altura;
        }

        public override double GetArea()
        {
            return this._basee * this._altura;
        }

        public override string ToString()
        {
            return $@"
            Área: {this.GetArea()}
            Base: {this._basee}
            Altura: {this._altura}
            Color [A=255, R=50, G=20, B=34]
            ";
        }

        internal override void CambiarColor(Color nuevoColor)
        {
            throw new NotImplementedException();
        }

    }
}
