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
    public partial class MenuClientes : Form
    {
        string valoresCelda;
        string Nombre;
        string Password;
        string Sexo;
        string Colonia;
        string Calle;
        string NumCasa;
        string fechaNacimiento;
        public MenuClientes(string UsuarioEmpleado)
        {
            InitializeComponent();
            ST_Usuario.Text = UsuarioEmpleado;
        }

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaClientes altaClientes= new AltaClientes(ST_Usuario.Text);
            altaClientes.Show();
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valoresCelda)==false)
            {
                Conexion conexion = new Conexion();
                List<string> datoCliente = conexion.ObtenerInfoCliente(valoresCelda);
                for (int i = 0; i < datoCliente.Count; i++)
                {
                    if (i == 0)
                    {
                        NumCasa = datoCliente[i];
                    }
                    else if (i == 1)
                    {
                        Colonia = datoCliente[i];
                    }
                    else if (i == 2)
                    {
                        Calle = datoCliente[i];
                    }
                    else if (i == 3)
                    {
                        Sexo = datoCliente[i];
                    }
                    else if (i == 4)
                    {
                        Nombre = datoCliente[i];
                    }
                    else if (i==5)
                    {
                        fechaNacimiento = datoCliente[i];
                    }
                    else if (i==6)
                    {
                        Password = datoCliente[i];
                    }
                }
                this.Hide();
                EditarCliente editarCliente = new EditarCliente(Nombre, Password, Sexo, Colonia, Calle, NumCasa, fechaNacimiento, valoresCelda,ST_Usuario.Text);
                editarCliente.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un CURP para poder editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valoresCelda = "";
            }
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuEmpleados menuEmpleados = new MenuEmpleados(ST_Usuario.Text);
            menuEmpleados.Show();
        }

        private void MenuClientes_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            DTG_AllClientes.DataSource = conexion.MostrarDatosAllClientes();
        }

        private void DTG_AllClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valoresCelda = DTG_AllClientes.CurrentRow.Cells["CURP"].Value.ToString();
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valoresCelda)==false)
            {
                DialogResult resultado = MessageBox.Show("Estas seguro que desea borrar a este Cliente", "Informacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    Conexion conexion = new Conexion();
                    conexion.borrarCliente(valoresCelda);
                    DTG_AllClientes.DataSource = conexion.MostrarDatosAllClientes();
                }
                else if (resultado == DialogResult.No)
                {
                    valoresCelda = "";
                    this.Hide();
                    this.Show();
                }
                else if (resultado == DialogResult.Cancel)
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
            else
            {
                MessageBox.Show("Seleccione un CURP para poder Eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valoresCelda = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
