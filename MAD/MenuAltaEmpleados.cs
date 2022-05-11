using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace MAD
{
    public partial class MenuAltaEmpleados : Form
    {
        string valoresCelda;
        public MenuAltaEmpleados()
        {
            InitializeComponent();
        }

        private void MenuAltaEmpleados_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            DTG_AllEmpleados.DataSource = conexion.MostrarDatosAllEmpleados();
        }

        private void BTN_Alta_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaEmpleados altaEmpleados = new AltaEmpleados();
            altaEmpleados.Show();
        }

        private void DTG_AllEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)//Obtiene la Fila de curp para sacar la informacion
        {
            valoresCelda= DTG_AllEmpleados.CurrentRow.Cells["CURP"].Value.ToString();//Obtiene el curp NAzzzzhi
        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valoresCelda) == false)
            {
                Conexion conexion = new Conexion();
                string CURP=null; 
                string RFC = null;
                string Usuario = null;
                string nombreEmpleado = null;
                string pass = null;
                string fechaNacimiento = null;
                List<string> dataEmpleado=conexion.ObtenerInfoEmpleado(valoresCelda);//Una vez obtenido el list con la informacion y lo pasamos para este nuevo list
                for (int i = 0; i < dataEmpleado.Count; i++)
                {
                    if (i == 0)//Como se como estan puestos cada uno de la informacion solo los pongo por numero para que se vaya agregando,bastante poco optimizado pero funciona xd
                    {
                        CURP = dataEmpleado[i];
                    }
                    else  if (i == 1)
                    {
                        RFC = dataEmpleado[i];
                    }
                    else if (i == 2)
                    {
                        Usuario = dataEmpleado[i];
                    }
                    else if (i==3)
                    {
                        pass = dataEmpleado[i];
                    }
                    else if (i == 4)
                    {
                        nombreEmpleado = dataEmpleado[i];
                    }
                    else if (i == 5)
                    {
                        fechaNacimiento = dataEmpleado[i];
                    }
                }
                this.Hide();
                EditarEmpleado editarEmpleados = new EditarEmpleado(CURP,RFC,Usuario,pass,nombreEmpleado,fechaNacimiento);//La informacion que obtenemos la pasamos a editar a una nueva ventana
                editarEmpleados.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un CURP para poder editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valoresCelda = "";
            }

        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valoresCelda) == false)
            {
                DialogResult resultado=MessageBox.Show("Esta seguro que desea borrar a este empleado", "Informacion", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    Conexion conexion = new Conexion();
                    conexion.borrarEmpleado(valoresCelda);
                    DTG_AllEmpleados.DataSource = conexion.MostrarDatosAllEmpleados();

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

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 incioSesion = new Form1();
            incioSesion.Show();
        }
    }
}
