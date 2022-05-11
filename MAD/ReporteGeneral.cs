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
    public partial class ReporteGeneral : Form
    {
        public ReporteGeneral(string Usuario)
        {
            InitializeComponent();
            LT_Usuario.Text = Usuario;
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuReportes menuReportes = new MenuReportes(LT_Usuario.Text);
            menuReportes.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ReporteGeneral_Load(object sender, EventArgs e)
        {
            CB_Año.Items.Add("Enero");
            CB_Año.Items.Add("Febrero");
            CB_Año.Items.Add("Marzo");
            CB_Año.Items.Add("Abril");
            CB_Año.Items.Add("Mayo");
            CB_Año.Items.Add("Junio");
            CB_Año.Items.Add("Julio");
            CB_Año.Items.Add("Agosto");
            CB_Año.Items.Add("Septiembre");
            CB_Año.Items.Add("Octubre");
            CB_Año.Items.Add("Noviembre");
            CB_Año.Items.Add("Diciembre");
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            if (string.IsNullOrEmpty(TB_IngresarCURP.Text)==false&&validacion.SoloLetrasOficial(TB_IngresarCURP.Text)==true)
            {
                if (string.IsNullOrEmpty(TB_Servicio.Text)==false && validacion.soloNumeros(TB_Servicio.Text)==true)
                {
                    if (string.IsNullOrEmpty(TB_MesBusqueda.Text)==false && validacion.soloNumeros(TB_MesBusqueda.Text)==true)
                    {
                        if (string.IsNullOrEmpty(CB_Año.Text)==false)
                        {
                            Conexion conexion = new Conexion();
                        }
                    }
                }
            }
        }

        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            if (string.IsNullOrEmpty(TB_IngresarCURP.Text) == false && validacion.SoloLetrasOficial(TB_IngresarCURP.Text) == true)
            {
                if (string.IsNullOrEmpty(TB_Servicio.Text) == false && validacion.soloNumeros(TB_Servicio.Text) == true)
                {
                    if (string.IsNullOrEmpty(TB_MesBusqueda.Text) == false && validacion.soloNumeros(TB_MesBusqueda.Text) == true)
                    {
                        if (string.IsNullOrEmpty(CB_Año.Text) == false)
                        {
                            Conexion conexion = new Conexion();
                            conexion.mostrarReporteGeneral(TB_IngresarCURP.Text,validacion.returnMesNumero(CB_Año.Text), TB_MesBusqueda.Text, TB_Servicio.Text);
                            MessageBox.Show("Se ha generado el reporte", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
 }
