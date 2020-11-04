using Datos;
using Entidades.Vistas;
using Entidades;
using System.Collections.Generic;

namespace Servicio
{
    public class ModeloService
    {
        ModeloDAO Servicio = new ModeloDAO();

        public List<GridModelo> ObtenerModelos()
        {
            return Servicio.ObtenerModelos();
        }

        public Modelo ObtenerPorID(int ModeloID)
        {
            return Servicio.ObtenerPorID(ModeloID);
        }

        public void Actualizar(Modelo Modelo)
        {
            Servicio.Actualizar(Modelo);
        }

        public void Insertar(Modelo Modelo)
        {
            Servicio.Insertar(Modelo);
        }

        public void Eliminar(int ModeloID)
        {
            Servicio.Eliminar(ModeloID);
        }
    }
}