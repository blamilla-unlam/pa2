using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class CajaDAO : Connection
    {
        public List<Caja> ObtenerCajas()
        {
            return Contexto.Caja
                .Select(s => new Caja {
                    CajaID = s.CajaID,
                    Nombre = s.Nombre })
                .OrderBy(o => o.Nombre)
                .ToList();
        }
        public Caja ObtenerPorID(int CajaID)
        {
            return Contexto.Caja
                .Select(s => new Caja
                {
                    CajaID = s.CajaID,
                    Nombre = s.Nombre
                })
                .Where(w => w.CajaID.Equals(CajaID))
                .FirstOrDefault();
        }

        public void Eliminar(int CajaID)
        {
            var Caja = Contexto.Caja.Find(CajaID);
            Contexto.Caja.Remove(Caja);
            Contexto.SaveChanges();
        }

        public void Actualizar(Caja Caja)
        {
            var caja = Contexto.Caja.Find(Caja.CajaID);

            if (caja != null)
            {
                caja.CajaID = Caja.CajaID;
                caja.Nombre = Caja.Nombre;

                Contexto.SaveChanges();
            }
        }

        public void Insertar(Caja Caja)
        {
            var caja = new ORM.Caja();
            caja.CajaID = Caja.CajaID;
            caja.Nombre = Caja.Nombre;

            Contexto.Caja.Add(caja);
            Contexto.SaveChanges();
        }
    }
}
