using Entidades;
using Entidades.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class VehiculoDAO : Connection
    {
        public List<GridVehiculo> ObtenerVehiculos()
        {
            return Contexto.Vehiculo
                .Select(s => new GridVehiculo {
                    VehiculoID = s.VehiculoID,
                    ModeloID = s.ModeloID,
                    MarcaID = s.Modelo.MarcaID,
                    NumeroChasis = s.NumeroChasis,
                    NumeroCarroceria = s.NumeroCarroceria,
                    Patente = s.Patente,
                    NumeroPuertas = s.NumeroPuertas,
                    ColorID = s.ColorID,
                    CajaID = s.CajaID,
                    Cilindrada = s.Cilindrada,
                    TapizadoID = s.TapizadoID })
                .OrderBy(o => new { o.NumeroChasis, o.NumeroCarroceria })
                .ToList();
        }

        public Vehiculo ObtenerPorID(int VehiculoID)
        {
            return Contexto.Vehiculo
                .Select(s => new Vehiculo {
                    VehiculoID = s.VehiculoID,
                    ModeloID = s.ModeloID,
                    MarcaID = s.Modelo.MarcaID,
                    NumeroChasis = s.NumeroChasis,
                    NumeroCarroceria = s.NumeroCarroceria,
                    Patente = s.Patente,
                    NumeroPuertas = s.NumeroPuertas,
                    ColorID = s.ColorID,
                    CajaID = s.CajaID,
                    Cilindrada = s.Cilindrada,
                    TapizadoID = s.TapizadoID
                })
                .Where(w => w.VehiculoID.Equals(VehiculoID))
                .FirstOrDefault();
        }

        public void Eliminar(int VehiculoID)
        {
            var Vehiculo = Contexto.Vehiculo.Find(VehiculoID);
            Contexto.Vehiculo.Remove(Vehiculo);
            Contexto.SaveChanges();
        }

        public void Actualizar(Vehiculo Vehiculo)
        {
            var vehiculo = Contexto.Vehiculo.Find(Vehiculo.VehiculoID);

            if (vehiculo != null)
            {
                vehiculo.Modelo.MarcaID = Vehiculo.MarcaID;
                vehiculo.ModeloID = Vehiculo.ModeloID;
                vehiculo.NumeroChasis = Vehiculo.NumeroChasis;
                vehiculo.NumeroCarroceria = Vehiculo.NumeroCarroceria;
                vehiculo.Patente = Vehiculo.Patente;
                vehiculo.NumeroPuertas= Vehiculo.NumeroPuertas;
                vehiculo.ColorID = Vehiculo.ColorID;
                vehiculo.CajaID = Vehiculo.CajaID;
                vehiculo.Cilindrada = Vehiculo.Cilindrada;
                vehiculo.TapizadoID = Vehiculo.TapizadoID;

                Contexto.SaveChanges();
            }
        }

        public void Insertar(Vehiculo Vehiculo)
        {
            var vehiculo = new ORM.Vehiculo();
            vehiculo.Modelo.MarcaID = Vehiculo.MarcaID;
            //vehiculo.ModeloID = Vehiculo.ModeloID;
            //vehiculo.NumeroChasis = Vehiculo.NumeroChasis;
            //vehiculo.NumeroCarroceria = Vehiculo.NumeroCarroceria;
            //vehiculo.Patente = Vehiculo.Patente;
            //vehiculo.NumeroPuertas = Vehiculo.NumeroPuertas;
            //vehiculo.Color = Vehiculo.Color;
            //vehiculo.Caja = Vehiculo.Caja;
            //vehiculo.Cilindrada = Vehiculo.Cilindrada;
            //vehiculo.Tapizado = Vehiculo.Tapizado;

            Contexto.Vehiculo.Add(vehiculo);
            Contexto.SaveChanges();
        }
    }
}
