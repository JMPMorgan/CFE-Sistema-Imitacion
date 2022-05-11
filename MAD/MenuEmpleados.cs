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
    public partial class MenuEmpleados : Form
    {
        public MenuEmpleados(string Usuario)
        {
            InitializeComponent();
            ST_Usuario.Text = Usuario;
        }

        private void BTN_Clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuClientes menuClientes = new MenuClientes(ST_Usuario.Text);
            menuClientes.Show();

        }

        private void BTN_Contratos_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuContratos menuContratos = new MenuContratos(ST_Usuario.Text);
            menuContratos.Show();
        }

        private void Tarifas_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuTarifas menuTarifas = new MenuTarifas(ST_Usuario.Text);
            menuTarifas.Show();

        }

        private void BTN_Consumos_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuConsumos menuConsumos = new MenuConsumos(ST_Usuario.Text);
            menuConsumos.Show();

        }

        private void BTN_Recibos_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuRecibo menuRecibo = new MenuRecibo(ST_Usuario.Text);
            menuRecibo.Show();
        }

        private void BTN_Reportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuReportes menuReportes = new MenuReportes(ST_Usuario.Text);
            menuReportes.Show();
        }
    }
}
