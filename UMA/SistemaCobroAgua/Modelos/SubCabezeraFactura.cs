using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCobroAgua.Modelos
{
    public class SubCabezeraFactura
    {
        public int SubCabezeraFacturaID { get; set; }
        public int CabezeraFacturaID { get; set; }
        [DataType(DataType.Date)]
        public DateTime FacturadoDesde { get; set; }
        [DataType(DataType.Date)]
        public DateTime FacturadoHasta { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd}", ApplyFormatInEditMode = true)]
        public DateTime DiasFacturados { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM}", ApplyFormatInEditMode = true)]
        public DateTime MesFacturado { get; set; }
        public string Region { get; set; }
        public string Grupo { get; set; }
        public string Ruta { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaEmision { get; set; }
        //relaciones.. propiedades virtuales polimorfismo

        public virtual CabezeraFactura CabezeraFactura { get; set; }
    }
}
