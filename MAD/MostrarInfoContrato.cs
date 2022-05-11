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
    public partial class MostrarInfoContrato : Form
    {
        public MostrarInfoContrato(string fechaCreacion,string numeroServicio,string numeroMedidor,string numeroContrato,string UserEmpleado,string CURPCliente,string direccionCasa,string entreCalles,string UsuarioActual)
        {
            InitializeComponent();
            ST_Cliente.Text = CURPCliente;
            ST_Contrato.Text = numeroContrato;
            ST_EmpleadoContrato.Text = UserEmpleado;
            ST_EntreCalles.Text = entreCalles;
            ST_Fecha.Text = fechaCreacion;
            ST_Medidor.Text = numeroMedidor;
            ST_Servicio.Text = numeroServicio;
            ST_UsuarioActual.Text = UsuarioActual;
            ST_Direccion.Text = direccionCasa;
        }

        private void MostrarInfoContrato_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Borrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea borrar este contrato", "Informacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (DialogResult.Yes==result)
            {
                Conexion conexion = new Conexion();
                int medidor = Convert.ToInt32(ST_Medidor.Text);
                conexion.borrarContrato(medidor);
                this.Hide();
                MenuContratos menuContratos = new MenuContratos(ST_UsuarioActual.Text);
                menuContratos.Show();
            }
            else if (DialogResult.No == result)
            {

            }
            else if (DialogResult.Cancel == result)
            {

            }
            else
            {
                MessageBox.Show("Que pedo esto no puede pasar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                this.Show();
            }

        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuContratos menuContratos = new MenuContratos(ST_UsuarioActual.Text);
            menuContratos.Show();
        }
    }
}
