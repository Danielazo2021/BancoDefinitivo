using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_BibliotecaDDL.DataAccess
{
    public interface IDaoReportes
    {
        public DataTable ReporteCuentas();
        public DataTable ReporteSaldos(int valor_dolar);
    }
}
