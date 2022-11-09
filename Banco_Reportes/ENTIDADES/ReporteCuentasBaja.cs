using Banco_Reportes.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Reportes.ENTIDADES
{
    public class ReporteCuentasBaja
    {
        public int Anio { get; set; }
        public string Mes { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public int Dni { get; set; }
    }
}
