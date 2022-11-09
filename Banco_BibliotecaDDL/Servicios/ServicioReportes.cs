using Banco_BibliotecaDDL.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_BibliotecaDDL.Servicios
{
    public class ServicioReportes : IServicioReportes
    {
        private IDaoReportes dao;
        public ServicioReportes()
        {
            dao = new DaoReportes();
        }
        public DataTable ReporteCuentas()
        {
            return dao.ReporteCuentas();
        }

        public DataTable ReporteCuentasBaja(DateTime desde, DateTime hasta)
        {
            return dao.ReporteCuentasBaja(desde,hasta);
        }

        public DataTable ReporteSaldos(int valor_dolar)
        {
            return dao.ReporteSaldos(valor_dolar);
        }
    }
}
