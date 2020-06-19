using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCobroAgua.Modelos
{
    public class Servicio
    {
        public int ServicioID { get; set; }
        public string NombreDeServicio { get; set; }       
        public double Precio { get; set; }
        public int COD { get; set; }
    }
}
