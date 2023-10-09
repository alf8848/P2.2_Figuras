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
            return (this._basee * this._altura); // Corregir el nombre de la variable 'vase' a 'basee'

        }
        public override string ToString()
        {
            return $@"
            Area: {this.GetArea()}
            Ancho: {this._basee} 
            Alto: {this._altura}
            ";
        }
    }
}
