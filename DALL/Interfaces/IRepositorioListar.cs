using System.Collections.Generic;

namespace DALL
{
    public interface IRepositorioListar<T> where T : class
    {
        List<T> Listar();
    }
}