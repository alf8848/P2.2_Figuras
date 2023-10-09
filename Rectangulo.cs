namespace P2_2_Figuras
{
    public class Rectangulo : Figura
    {
        private double _basee;
        private double _altura;

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
            ";
        }
    }
}
