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
        public Marca ObtenerPorID(int MarcaID)
        {
            return Servicio.ObtenerPorID(MarcaID);
        }

        public void Actualizar(Marca Marca)
        {
            Servicio.Actualizar(Marca);
        }

        public void Insertar(Marca Marca)
        {
            Servicio.Insertar(Marca);
        }

        public void Eliminar(int MarcaID)
        {
            Servicio.Eliminar(MarcaID);
        }
    }
}
