using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCobroAgua.Modelos
{
    public class TarifaResidencial
    {
        public int TarifaResidencialID { get; set; }
        public string RangosDeConsumoEnMetrosCubicos { get; set; }
        public double TarifaAcueductoPrecioPorM3 { get; set; }
        public double TarifasAlcantarillado { get; set; }
    }
}
