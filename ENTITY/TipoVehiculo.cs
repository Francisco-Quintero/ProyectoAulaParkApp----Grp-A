namespace ENTITY
{
    public class TipoVehiculo
    {
        public TipoVehiculo()
        {
                
        }
        public TipoVehiculo(string descripcion)
        {
            Descripcion = descripcion;
        }

        public TipoVehiculo(int idTipoVehiculo, string descripcion)
        {
            IdTipoVehiculo = idTipoVehiculo;
            Descripcion = descripcion;
        }

        public int IdTipoVehiculo { get; set; }
        public string Descripcion { get; set; }

      
    }
}
