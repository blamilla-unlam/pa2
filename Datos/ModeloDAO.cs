using Entidades;
using Entidades.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class ModeloDAO : Connection
    {
        public List<GridModelo> ObtenerModelos()
        {
            return Contexto.Modelo
                .Select(s => new GridModelo {
                    ModeloID = s.ModeloID,
                    Marca = s.Marca.Nombre,
                    Nombre = s.Nombre })
                .OrderBy(o => new { o.Marca, o.Nombre })
                .ToList();
        }

        public Modelo ObtenerPorID(int ModeloID)
        {
            return Contexto.Modelo
                .Select(s => new Modelo {
                    ModeloID = s.ModeloID,
                    MarcaID = s.MarcaID,
                    Nombre = s.Nombre})
                .Where(w => w.ModeloID.Equals(ModeloID))
                .FirstOrDefault();
        }

        public void Eliminar(int ModeloID)
        {
            var Modelo = Contexto.Modelo.Find(ModeloID);
            Contexto.Modelo.Remove(Modelo);
            Contexto.SaveChanges();
        }

        public void Actualizar(Modelo Modelo)
        {
            var modelo = Contexto.Modelo.Find(Modelo.ModeloID);

            if (modelo != null)
            {
                modelo.MarcaID = Modelo.MarcaID;
                modelo.Nombre = Modelo.Nombre;

                Contexto.SaveChanges();
            }
        }

        public void Insertar(Modelo Modelo)
        {
            var modelo = new ORM.Modelo();
            modelo.MarcaID = Modelo.MarcaID;
            modelo.Nombre = Modelo.Nombre;

            Contexto.Modelo.Add(modelo);
            Contexto.SaveChanges();
        }
    }
}
