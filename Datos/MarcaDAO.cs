using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class MarcaDAO : Connection
    {
        public List<Marca> ObtenerMarcas()
        {
            return Contexto.Marca
                .Select(s => new Marca {
                    MarcaID = s.MarcaID,
                    Nombre = s.Nombre })
                .OrderBy(o => o.Nombre)
                .ToList();
        }
        public Marca ObtenerPorID(int MarcaID)
        {
            return Contexto.Marca
                .Select(s => new Marca
                {
                    MarcaID = s.MarcaID,
                    Nombre = s.Nombre
                })
                .Where(w => w.MarcaID.Equals(MarcaID))
                .FirstOrDefault();
        }

        public void Eliminar(int MarcaID)
        {
            var Marca = Contexto.Marca.Find(MarcaID);
            Contexto.Marca.Remove(Marca);
            Contexto.SaveChanges();
        }

        public void Actualizar(Marca Marca)
        {
            var marca = Contexto.Marca.Find(Marca.MarcaID);

            if (marca != null)
            {
                marca.MarcaID = Marca.MarcaID;
                marca.Nombre = Marca.Nombre;

                Contexto.SaveChanges();
            }
        }

        public void Insertar(Marca Marca)
        {
            var marca = new ORM.Marca();
            marca.MarcaID = Marca.MarcaID;
            marca.Nombre = Marca.Nombre;

            Contexto.Marca.Add(marca);
            Contexto.SaveChanges();
        }
    }
}
