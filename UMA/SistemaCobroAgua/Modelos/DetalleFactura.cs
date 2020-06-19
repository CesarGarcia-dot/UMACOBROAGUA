using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCobroAgua.Modelos
{
    public class DetalleFactura
    {
        public int DetalleFacturaID { get; set; }
        public int ServicioID { get; set; }
        public int CabezeraFacturaID { get; set; }
        public double VentasExentas { get; set; }
        public double VentasGravadas { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        //relaciones.. propiedades virtuales polimorfismo
        public virtual Servicio Servicio { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
        public virtual CabezeraFactura CabezeraFactura { get; set; }
        public virtual ICollection<CabezeraFactura> CabezeraFacturas { get; set; }

    }
}
