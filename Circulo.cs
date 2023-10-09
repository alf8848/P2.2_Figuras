using P2_2_Figuras;

namespace P2_2_Figuras
{
    public class Circulo : Figura // Usa "Figura" en lugar de "figura" para seguir la convención de nomenclatura.
    {
        protected double _radio;

        public Circulo(double radio) => this._radio = radio;

        public override double GetArea()
        {
            return Math.PI * (this._radio * this._radio);
        }

        public override string ToString()
        {
            return $@"
            Area: {this.GetArea()}
            Radio: {this._radio} 
            ";
        }
    }


}
