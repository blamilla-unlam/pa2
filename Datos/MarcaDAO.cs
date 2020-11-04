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
    }
}
