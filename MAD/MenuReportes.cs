using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD
{
    public partial class MenuReportes : Form
    {
        public MenuReportes(string Usuario)
        {
            InitializeComponent();
            LT_Usuario.Text = Usuario;
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuEmpleados menuEmpleados = new MenuEmpleados(LT_Usuario.Text);
            menuEmpleados.Show();
        }

        private void BTN_General_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteGeneral reporteGeneral = new ReporteGeneral(LT_Usuario.Text);
            reporteGeneral.Show();
        }

        private void BTN_Tarifas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte reporteTarifas = new Reporte(LT_Usuario.Text,1);
            reporteTarifas.Show();
        }

        private void BTN_Consumo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte reporteConsumo = new Reporte(LT_Usuario.Text,2);
            reporteConsumo.Show();
        }

        private void MenuReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
