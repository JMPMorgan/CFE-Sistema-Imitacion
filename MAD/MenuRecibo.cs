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
    public partial class MenuRecibo : Form
    {
        public MenuRecibo(string Usuario)
        {
            InitializeComponent();
            LB_Usuario.Text = Usuario;
        }

        string valoresCelda;
        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuEmpleados menuEmpleados = new MenuEmpleados(LB_Usuario.Text);
            menuEmpleados.Show();
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            if (string.IsNullOrEmpty(TB_MesInicio.Text) == false && string.IsNullOrWhiteSpace(TB_MesInicio.Text)==false && validacion.soloNumeros(TB_MesInicio.Text)==true)
            {
                if(string.IsNullOrEmpty(TB_NumeroRecibo.Text)==false && string.IsNullOrWhiteSpace(TB_NumeroRecibo.Text)==false && validacion.soloNumeros(TB_NumeroRecibo.Text) == true)
                {
                    Conexion conexion = new Conexion();
                    DTG_AllRecibos.DataSource=conexion.mostrarRecibo(TB_MesInicio.Text, TB_NumeroRecibo.Text);

                }
            }
        }

        private void TB_NumeroRecibo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_VerRecibo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valoresCelda)==false)
            {
                Conexion conexion = new Conexion();
                conexion.generarReciboPDF(TB_MesInicio.Text,TB_NumeroRecibo.Text);
                MessageBox.Show("Recibo generado con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DTG_AllRecibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valoresCelda = DTG_AllRecibos.CurrentRow.Cells["numeroMedidor"].Value.ToString();
        }

        private void MenuRecibo_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Pagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valoresCelda)==false)
            {
                Conexion conexion = new Conexion();
                List<string> info = conexion.getInfoFormaPago(valoresCelda);
                string numeroContrato = null, consumoTotal = null, fechaCreacion = null, nombreDeTarifa = null, tarifaBasico = null, tarifaMedio = null, tarifaExcedente = null;

                for (int i = 0; i < info.Count; i++)
                {
                    if (i==0)
                    {
                        numeroContrato = info[i];
                    }
                    else if (i==1)
                    {
                        consumoTotal = info[i];
                    }
                    else if (i == 2)
                    {
                        fechaCreacion = info[i];
                    }
                    else if (i == 3)
                    {
                        nombreDeTarifa = info[i];
                    }
                    else if (i == 4)
                    {
                        tarifaBasico = info[i];
                    }
                    else if (i == 5)
                    {
                        tarifaMedio = info[i];
                    }
                    else if (i == 6)
                    {
                        tarifaExcedente = info[i];
                    }
                }
                this.Hide();
                PagarRecibo pagarRecibo = new PagarRecibo(fechaCreacion,valoresCelda,consumoTotal,tarifaBasico,tarifaMedio,tarifaExcedente,numeroContrato,nombreDeTarifa,LB_Usuario.Text);
                pagarRecibo.Show();
            }
        }
    }
}
