using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCobroAgua.Modelos
{
    public class PieFactura
    {
        public int PieFacturaID { get; set; }
        public int CabezeraFacturaID { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public string UltimoDiaDePago { get; set; }
        //relaciones.. propiedades virtuales polimorfismo
        public virtual CabezeraFactura CabezeraFactura { get; set; }
    }
}
