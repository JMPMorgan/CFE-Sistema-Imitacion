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
    public partial class MenuContratos : Form
    {

        string valoresCelda;
        public MenuContratos(string Usuario)
        {
            InitializeComponent();
            ST_Usuario.Text = Usuario;
        }

        private void BTN_AgregarContrato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valoresCelda) == false || string.IsNullOrWhiteSpace(valoresCelda) == false)
            {
                Conexion conexion = new Conexion();
                if (conexion.verificarExistenciaCliente(valoresCelda)==true)
                {
                    string nombreCliente = null;
                    string direccionCasa = null;
                    string usuario = null;
                    string CURP = null;
                    List<string> dataEmpleado = conexion.ObtenerInfoClienteContrato(valoresCelda);//Una vez obtenido el list con la informacion y lo pasamos para este nuevo list
                    for (int i = 0; i < dataEmpleado.Count; i++)
                    {
                        if (i == 0)//Como se como estan puestos cada uno de la informacion solo los pongo por numero para que se vaya agregando,bastante poco optimizado pero funciona xd
                        {
                            nombreCliente = dataEmpleado[i];
                        }
                        else if (i == 1)
                        {
                            direccionCasa = dataEmpleado[i];
                        }
                        else if (i == 2)
                        {
                           direccionCasa = direccionCasa+" " + dataEmpleado[i];
                        }
                        else if (i == 3)
                        {
                            direccionCasa =direccionCasa+" "+ dataEmpleado[i];
                        }
                        else if (i == 4)
                        {
                            usuario= dataEmpleado[i];
                        }
                        else if (i == 5)
                        {
                            CURP = dataEmpleado[i];
                        }
                    }
                    this.Hide();
                    NuevoContrato nuevoContrato = new NuevoContrato(nombreCliente,direccionCasa,usuario,CURP,ST_Usuario.Text);
                    nuevoContrato.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un CURP para poder editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_MostrarContratos_Click(object sender, EventArgs e)
        {
            this.Hide();
            MostrarContratos mostrarContratos = new MostrarContratos(valoresCelda,ST_Usuario.Text);
            mostrarContratos.Show();
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuEmpleados menuEmpleados = new MenuEmpleados(ST_Usuario.Text);
            menuEmpleados.Show();
        }

        private void DTG_AllClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valoresCelda = DTG_AllClientes.CurrentRow.Cells["CURP"].Value.ToString();//Obtiene el curp NAzzzzhi
        }

        private void TB_Buscar_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TB_Buscar.Text)==false || string.IsNullOrWhiteSpace(TB_Buscar.Text) == false)
            {
                Conexion conexion = new Conexion();
                DTG_AllClientes.DataSource=conexion.MostrarAllClientesContratos(TB_Buscar.Text);
            }
        }
    }
}
