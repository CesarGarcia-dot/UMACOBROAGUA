using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCobroAgua.Modelos
{
    public class Factura
    {
        public int FacturaID { get; set; }
        public int CabezeraFacturaID { get; set; }
        public int SubCabezeraFacturaID { get; set; }
        public int PieFacturaID { get; set; }

        //relaciones.. propiedades virtuales polimorfismo
        public virtual CabezeraFactura CabezeraFactura { get; set; }
        public virtual SubCabezeraFactura SubCabezeraFactura { get; set; }       
        public virtual PieFactura PieFactura { get; set; }
    }
}
