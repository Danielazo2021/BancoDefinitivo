using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_BibliotecaDDL.Servicios
{
    public interface IServicioReportes
    {
        public DataTable ReporteCuentas();
        public DataTable ReporteSaldos(int valor_dolar);
        public DataTable ReporteCuentasBaja(DateTime desde, DateTime hasta);
    }
}
