using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaCobroAgua.Modelos
{
    public class CabezeraFactura
    {
        public int CabezeraFacturaID { get; set; }
        public string NumeroDeCuenta { get; set; }
        public string NumeroDeFactura { get; set; }
        public string NRC { get; set; }
        public string  NIT { get; set; }
        public string Giro { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public int ClienteID { get; set; }
        //propiedades virtuales para navegar en propiedades y acceder, (polimorfismo)

        public virtual Cliente Cliente { get; set; }
    }
}
