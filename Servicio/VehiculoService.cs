using Datos;
using Entidades.Vistas;
using Entidades;
using System.Collections.Generic;

namespace Servicio
{
    public class VehiculoService
    {
        VehiculoDAO Servicio = new VehiculoDAO();

        public List<GridVehiculo> ObtenerVehiculos()
        {
            return Servicio.ObtenerVehiculos();
        }

        public Vehiculo ObtenerPorID(int VehiculoID)
        {
            return Servicio.ObtenerPorID(VehiculoID);
        }

        public void Actualizar(Vehiculo Vehiculo)
        {
            Servicio.Actualizar(Vehiculo);
        }

        public void Insertar(Vehiculo Vehiculo)
        {
            Servicio.Insertar(Vehiculo);
        }

        public void Eliminar(int VehiculoID)
        {
            Servicio.Eliminar(VehiculoID);
        }
    }
}