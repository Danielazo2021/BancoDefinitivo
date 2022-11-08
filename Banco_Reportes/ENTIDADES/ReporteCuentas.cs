using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Reportes.ENTIDADES
{
    public class ReporteCuentas
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public double Cbu { get; set; }
        public double Saldo { get; set; }
        public DateTime? UltimoMovimiento { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string NombreCuenta { get; set; }
    }
}
