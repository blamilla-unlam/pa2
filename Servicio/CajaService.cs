using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicio
{
    public class CajaService
    {
        CajaDAO Servicio = new CajaDAO();

        public List<Caja> ObtenerCajas()
        {
            return Servicio.ObtenerCajas();
        }
        public Caja ObtenerPorID(int CajaID)
        {
            return Servicio.ObtenerPorID(CajaID);
        }

        public void Actualizar(Caja Caja)
        {
            Servicio.Actualizar(Caja);
        }

        public void Insertar(Caja Caja)
        {
            Servicio.Insertar(Caja);
        }

        public void Eliminar(int CajaID)
        {
            Servicio.Eliminar(CajaID);
        }
    }
}
