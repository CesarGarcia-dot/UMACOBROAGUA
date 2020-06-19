using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCobroAgua.Modelos
{
    public class TarifaDeEstablecimiento
    {
        public int TarifaDeEstablecimientoID { get; set; }
        public string RangosDeConsumoEnMetrosCubicos { get; set; }
        public double TarifaAcueductoM3 { get; set; }
        public double TarifaAlcantarillado { get; set; }
    }
}
