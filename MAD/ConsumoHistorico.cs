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
    public partial class ConsumoHistorico : Form
    {
        public ConsumoHistorico()
        {
            InitializeComponent();
        }

        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            if (validacion.soloNumeros(TB_Ano.Text)==true&& string.IsNullOrEmpty(TB_Ano.Text)==false)
            {
                if (validacion.soloNumeros(TB_medidor.Text)==true && string.IsNullOrEmpty(TB_medidor.Text)==false)
                {
                    if (validacion.soloNumeros(TB_servicio.Text)==true && string.IsNullOrEmpty(TB_servicio.Text)==false)
                    {
                        Conexion conexion = new Conexion();
                        conexion.generarConsumoHistorico(TB_Ano.Text,TB_medidor.Text,TB_servicio.Text);
                        MessageBox.Show("Reporte Generado con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MenuClientesSesion menuClientesSesion = new MenuClientesSesion();
                        menuClientesSesion.Show();
                    }
                }
            }
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuClientesSesion menuClientesSesion = new MenuClientesSesion();
            menuClientesSesion.Show();
        }
    }
}
