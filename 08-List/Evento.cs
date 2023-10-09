namespace _08_list
{
    public class Evento
    {
        protected DateTime _comienzo;
        protected TimeSpan _duracion;
        protected string? _titulo;
        protected string? _descripcion;

        public Evento(DateTime comienzo, TimeSpan duracion, string titulo, string descripcion)
        {
            this._comienzo = comienzo;
            this._duracion = duracion;
            this._titulo = titulo;
            this._descripcion = descripcion;
        }

        public override string ToString()
        {
            return $@"
            Titulo: {this._titulo}
            Fecha y hora: {this._comienzo}
            Duración: {this._duracion}
            Descripción: {this._descripcion}
            ";
        }
    }
}

