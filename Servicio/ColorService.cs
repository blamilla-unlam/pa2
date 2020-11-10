using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicio
{
    public class ColorService
    {
        ColorDAO Servicio = new ColorDAO();

        public List<Color> ObtenerColores()
        {
            return Servicio.ObtenerColores();
        }
        public Color ObtenerPorID(int ColorID)
        {
            return Servicio.ObtenerPorID(ColorID);
        }

        public void Actualizar(Color Color)
        {
            Servicio.Actualizar(Color);
        }

        public void Insertar(Color Color)
        {
            Servicio.Insertar(Color);
        }

        public void Eliminar(int ColorID)
        {
            Servicio.Eliminar(ColorID);
        }
    }
}
