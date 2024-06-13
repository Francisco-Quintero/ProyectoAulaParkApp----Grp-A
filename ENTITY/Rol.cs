namespace ENTITY
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public Rol()
        {
            
        }

        public Rol(int idRol, string nombre, bool estado)
        {
            IdRol = idRol;
            Nombre = nombre;
            Estado = estado;
        }
    }
}