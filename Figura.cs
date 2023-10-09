using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras
{
    public abstract class Figura
    {
        protected Color _color;

        public abstract double GetArea();
        public void CambiarColor(string nuevoColor)
        {
            _color = Color.FromName(nuevoColor);
        }

        internal abstract void CambiarColor(Color nuevoColor);

        public virtual string GetColorName()
        {
            return _color.Name;
        }

        internal void CambiarColor(object nuevoColor)
        {
            throw new NotImplementedException();
        }
    }
}
