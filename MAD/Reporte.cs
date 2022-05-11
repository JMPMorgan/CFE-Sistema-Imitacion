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
    public partial class Reporte : Form
    {
        int reporteGlobal = 0;//1= tarifa,2= conusmo
        public Reporte(string Usuario,int reporte)
        {
            InitializeComponent();
            LT_Usuario.Text = Usuario;
            reporteGlobal = reporte;
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuReportes menuReportes = new MenuReportes(LT_Usuario.Text);
            menuReportes.Show();
        }

        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            if (validacion.soloNumeros(TB_Año.Text)==true && string.IsNullOrEmpty(TB_Año.Text)==false)
            {
                if (reporteGlobal==1)
                {
                    Conexion conexion = new Conexion();
                    conexion.mostrarReporteTarifa(TB_Año.Text);
                    MessageBox.Show("Se ha generado el reporte", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (reporteGlobal == 2)
                {
                    Conexion conexion = new Conexion();
                    conexion.mostratReporteConsumo(TB_Año.Text);
                    MessageBox.Show("Se ha generado el reporte", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
