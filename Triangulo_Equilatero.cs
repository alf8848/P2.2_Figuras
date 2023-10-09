namespace P2_2_Figuras
{

    public class Triangulo_Equilatero : Figura
    {
        private double _lado;

        public Triangulo_Equilatero(double lado) => this._lado = lado;

        public override double GetArea()
        {
            return (this._lado * this._lado); // Corregir el nombre de la variable 'vase' a 'basee'
        }

        public override string ToString()
        {
            return $@"
            Area: {this.GetArea()}
            Radio: {this._lado} 
            ";
        }
    }
}
