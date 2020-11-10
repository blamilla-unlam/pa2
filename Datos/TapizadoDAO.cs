using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class TapizadoDAO : Connection
    {
        public List<Tapizado> ObtenerTapizados()
        {
            return Contexto.Tapizado
                .Select(s => new Tapizado {
                    TapizadoID = s.TapizadoID,
                    Nombre = s.Nombre })
                .OrderBy(o => o.Nombre)
                .ToList();
        }
        public Tapizado ObtenerPorID(int TapizadoID)
        {
            return Contexto.Tapizado
                .Select(s => new Tapizado
                {
                    TapizadoID = s.TapizadoID,
                    Nombre = s.Nombre
                })
                .Where(w => w.TapizadoID.Equals(TapizadoID))
                .FirstOrDefault();
        }

        public void Eliminar(int TapizadoID)
        {
            var Tapizado = Contexto.Tapizado.Find(TapizadoID);
            Contexto.Tapizado.Remove(Tapizado);
            Contexto.SaveChanges();
        }

        public void Actualizar(Tapizado Tapizado)
        {
            var tapizado = Contexto.Tapizado.Find(Tapizado.TapizadoID);

            if (tapizado != null)
            {
                tapizado.TapizadoID = Tapizado.TapizadoID;
                tapizado.Nombre = Tapizado.Nombre;

                Contexto.SaveChanges();
            }
        }

        public void Insertar(Tapizado Tapizado)
        {
            var tapizado = new ORM.Tapizado();
            tapizado.TapizadoID = Tapizado.TapizadoID;
            tapizado.Nombre = Tapizado.Nombre;

            Contexto.Tapizado.Add(tapizado);
            Contexto.SaveChanges();
        }
    }
}
