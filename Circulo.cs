using System.Drawing;
using P2_2_Figuras;

namespace P2_2_Figuras
{
    public class Circulo : Figura // Usa "Figura" en lugar de "figura" para seguir la convención de nomenclatura.
    {
        protected double _radio;
        private Color red;

        public Circulo(double radio)
        {
            this._radio = radio;
        }

        public Circulo(Color red)
        {
            this.red = red;
        }

        public Circulo(double radio, TimeSpan timeSpan) => this._radio = radio;

        public Color Color { get; internal set; }

        public override double GetArea()
        {
            return Math.PI * (this._radio * this._radio);
        }

        public override string ToString()
        {
            return $@"
            Area: {this.GetArea()}
            Radio: {this._radio}
            Color [A=255, R=0, G=20, B=35] 
            ";
        }

        internal override void CambiarColor(Color nuevoColor)
        {
            _color = nuevoColor;
        }
    }


}
