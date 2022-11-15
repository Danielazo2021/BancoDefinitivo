using Banco_Reportes.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Reportes.FORMULARIOS
{
    public partial class FormReporteCuentasBaja : Form
    {
        private readonly HttpClient HttpClient;
        List<ReporteCuentasBaja> lista_cuentas_baja;
        public FormReporteCuentasBaja()
        {
            InitializeComponent();

            HttpClient = new HttpClient();
            lista_cuentas_baja = new List<ReporteCuentasBaja>();

        }
        private void FormReporteCuentas_Load(object sender, EventArgs e)
        {
            
        }
        private void Enviar()
        {
            DateTime h = dtpDesde.Value;
            string fecha = h.ToString("dd-MM-yy");

        }

        private  void CargarReportes()
        {
            
        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
           
            await FiltrarAsync();
        }


        private async Task FiltrarAsync()
        {
            DateTime fecha_desde = dtpDesde.Value;
            //string desde = fecha_desde.ToString("MM-dd-yy");
            string desde = fecha_desde.ToString("yyyy-MM-dd");

            DateTime fecha_hasta = dtpHasta.Value;
            //string hasta = fecha_hasta.ToString("MM-dd-yy");
            string hasta = fecha_hasta.ToString("yyyy-MM-dd");
            await GerReporteCuentasBaja(desde, hasta);
             this.reportViewer1.RefreshReport();
        }


        
        public async Task<string> GerReporteCuentasBaja(string desde, string hasta)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7224/api/Reportes/" + desde + "/" + hasta))
            {
                var response = await HttpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var bodyJSON = await response.Content.ReadAsStringAsync();
                lista_cuentas_baja = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ReporteCuentasBaja>>(bodyJSON);
                reporteCuentasBajaBindingSource.DataSource = lista_cuentas_baja;
                return await response.Content.ReadAsStringAsync();
            }
        }

        private void FormReporteCuentasBaja_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
