using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Vistas
{
    public class GridVehiculo
    {
        public int VehiculoID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int NumeroChasis { get; set; }
        public int NumeroCarroceria { get; set; }
        public string Patente { get; set; }
        public short NumeroPuertas { get; set; }
        public string Color { get; set; }
        public string Caja { get; set; }
        public decimal Cilindrada { get; set; }
        public string Tapizado { get; set; }
    }
}
