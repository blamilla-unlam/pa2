using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class ColorDAO : Connection
    {
        public List<Color> ObtenerColores()
        {
            return Contexto.Color
                .Select(s => new Color {
                    ColorID = s.ColorID,
                    Nombre = s.Nombre })
                .OrderBy(o => o.Nombre)
                .ToList();
        }
        public Color ObtenerPorID(int ColorID)
        {
            return Contexto.Color
                .Select(s => new Color
                {
                    ColorID = s.ColorID,
                    Nombre = s.Nombre
                })
                .Where(w => w.ColorID.Equals(ColorID))
                .FirstOrDefault();
        }

        public void Eliminar(int ColorID)
        {
            var Color = Contexto.Color.Find(ColorID);
            Contexto.Color.Remove(Color);
            Contexto.SaveChanges();
        }

        public void Actualizar(Color Color)
        {
            var color = Contexto.Color.Find(Color.ColorID);

            if (color != null)
            {
                color.ColorID = Color.ColorID;
                color.Nombre = Color.Nombre;

                Contexto.SaveChanges();
            }
        }

        public void Insertar(Color Color)
        {
            var color = new ORM.Color();
            color.ColorID = Color.ColorID;
            color.Nombre = Color.Nombre;

            Contexto.Color.Add(color);
            Contexto.SaveChanges();
        }
    }
}
