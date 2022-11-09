
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_BibliotecaDDL.DataAccess
{
    public class DaoReportes : IDaoReportes
    {
        public DataTable ReporteCuentas()
        {
            string sp_nombre = "SP_REPORTE_CLIENTES";
            return HelperDao.ObtenerInstancia().ReporteCuentas(sp_nombre);
        }
        public DataTable ReporteSaldos(int valor_dolar)
        {
            string sp_nombre = "SP_REPORTE_SALDOS_CUENTAS";
            return HelperDao.ObtenerInstancia().ReporteSaldos(sp_nombre,valor_dolar);
        }
        public DataTable ReporteCuentasBaja(DateTime desde, DateTime hasta)
        {
            string sp_nombre = "sp_CuentasDadasDeBaja_Con_Parametros";
            return HelperDao.ObtenerInstancia().ReporteCuentasBaja(sp_nombre,desde,hasta);
        }
    }
}
