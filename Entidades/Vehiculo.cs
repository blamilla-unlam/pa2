using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        public int VehiculoID { get; set; }
        public int MarcaID { get; set; }
        public int ModeloID { get; set; }
        public int NumeroChasis { get; set; }
        public int NumeroCarroceria { get; set; }
        public string Patente { get; set; }
        public short NumeroPuertas { get; set; }
        public int Color { get; set; }
        public int Caja { get; set; }
        public decimal Cilindrada { get; set; }
        public int Tapizado { get; set; }
    }
}
