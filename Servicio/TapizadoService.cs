using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicio
{
    public class TapizadoService
    {
        TapizadoDAO Servicio = new TapizadoDAO();

        public List<Tapizado> ObtenerTapizados()
        {
            return Servicio.ObtenerTapizados();
        }
        public Tapizado ObtenerPorID(int TapizadoID)
        {
            return Servicio.ObtenerPorID(TapizadoID);
        }

        public void Actualizar(Tapizado Tapizado)
        {
            Servicio.Actualizar(Tapizado);
        }

        public void Insertar(Tapizado Tapizado)
        {
            Servicio.Insertar(Tapizado);
        }

        public void Eliminar(int TapizadoID)
        {
            Servicio.Eliminar(TapizadoID);
        }
    }
}
