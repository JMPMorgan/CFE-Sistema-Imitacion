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
    public partial class MenuTarifas : Form
    {
        string valoresCelda;
        public MenuTarifas(string UsuarioEmpleado)
        {
            InitializeComponent();
            ST_Usuario.Text = UsuarioEmpleado;
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            NuevaTarifa nuevaTarifa = new NuevaTarifa(ST_Usuario.Text);
            nuevaTarifa.Show();
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuEmpleados menuEmpleados = new MenuEmpleados(ST_Usuario.Text);
            menuEmpleados.Show();
        }

        private void DTG_AllTarifas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valoresCelda = DTG_AllTarifas.CurrentRow.Cells["nombreTarifa"].Value.ToString();
        }

        private void MenuTarifas_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            DTG_AllTarifas.DataSource=conexion.MostrarAllTarifas();

        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valoresCelda)==false)
            {
                DialogResult result = MessageBox.Show("Estas seguro que desea borrar esta tarifa", "Informacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result==DialogResult.Yes)
                {
                    Conexion conexion = new Conexion();
                    conexion.borrarTarifa(valoresCelda);
                    DTG_AllTarifas.DataSource = conexion.MostrarAllTarifas();
                }
                else if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    valoresCelda = "";
                    this.Hide();
                    this.Show();
                }
                else
                {
                    valoresCelda = "";
                    MessageBox.Show("Que pedo esto no puede pasar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                    this.Show();
                }
            }

        }
    }
}
