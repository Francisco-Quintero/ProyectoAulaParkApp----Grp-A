namespace ENTITY
{
    public class TipoParqueadero
    {
        public string Descripcion { get; set; }
        public string TipoParqueaderos { get; set; }

        public TipoParqueadero(string descripcion, string tipoParqueaderos)
        {
            Descripcion = descripcion;
            TipoParqueaderos = tipoParqueaderos;
        }

        public TipoParqueadero(string descripcion)
        {
            Descripcion = descripcion;
        }

        public TipoParqueadero()
        {
            
        }
    }
}