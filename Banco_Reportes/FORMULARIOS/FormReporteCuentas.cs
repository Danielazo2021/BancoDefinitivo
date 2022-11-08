using Banco_Reportes.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Reportes.FORMULARIOS
{
    public partial class FormReporteCuentas : Form
    {

        private readonly HttpClient HttpClient;
        List<ReporteCuentas> lista_cuentas;
        List<ReporteSaldos> lista;
        public FormReporteCuentas()
        {
            InitializeComponent();

            HttpClient = new HttpClient();
            lista_cuentas = new List<ReporteCuentas>();
            lista = new List<ReporteSaldos>();
            
        }
        private void FormReporteCuentas_Load(object sender, EventArgs e)
        {
            this.reportViewer2.RefreshReport();
        }


        private async void CargarReportes()
        {
            if (txtValorDolar.Text!="")
            {
              await  GetReporteSaldos(Convert.ToInt32(txtValorDolar.Text));
                await GetReporteCuentas();
                this.reportViewer2.RefreshReport();
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN VALOR");
            }
        }
        public async Task<string> GetReporteCuentas()
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7224/ReporteCuentas"))
            {
                var response = await HttpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var bodyJSON = await response.Content.ReadAsStringAsync();
                lista_cuentas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ReporteCuentas>>(bodyJSON);
                reporteCuentasBindingSource1.DataSource = lista_cuentas;

                return await response.Content.ReadAsStringAsync();
            }
        }
        public async Task<string> GetReporteSaldos(int valor_dolar)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7224/api/Reportes/+"+valor_dolar))
            {
                var response = await HttpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var bodyJSON = await response.Content.ReadAsStringAsync();
                lista = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ReporteSaldos>>(bodyJSON);
                reporteSaldosBindingSource.DataSource = lista;
                return await response.Content.ReadAsStringAsync();
            }
        }

        private void txtValorDolar_TextChanged(object sender, EventArgs e)
        {
            if (!X(txtValorDolar.Text))
            {
                MessageBox.Show("PRECIO INCORRECTO");
                txtValorDolar.Text = "";
            }
        }
        private bool X(string campo)
        {
            bool b = false;
            if (campo != "")
            {
                for (int i = 0; i < campo.Length; i++)
                {
                    if (Char.IsDigit(campo, i))
                    {
                        b = true;
                    }
                    else
                    {
                        b = false;
                    }
                }
            }
            else
            {
                b = true;
            }
            return b;
        }

        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            CargarReportes();
            this.reportViewer2.RefreshReport();
        }
    }
}
