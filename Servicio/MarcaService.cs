using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicio
{
    public class MarcaService
    {
        MarcaDAO Servicio = new MarcaDAO();

        public List<Marca> ObtenerMarcas()
        {
            return Servicio.ObtenerMarcas();
        }
    }
}
