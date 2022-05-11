using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.Validaciones;

namespace MAD
{
    public partial class AltaEmpleados : Form
    {
        public AltaEmpleados()
        {
            InitializeComponent();
        }
        public void Limpiar()//Limpia los textbox
        {
            TB_Nombre.Text = "";
            TB_RFC.Text = "";
            TB_CURP.Text = "";
            TB_Usuario.Text = "";
            TB_Contraseña.Text = "";
        }
        private void BTN_Guradar_Click(object sender, EventArgs e)
        {
            Validacion validacion = new Validacion();
            DateTime Nacimiento = DTP_Nacimiento.Value;
            DateTime rightNow = DTP_Nacimiento.Value;
            string nacimiento = Nacimiento.ToString("dd/MM/yyyy");
            Nacimiento = Convert.ToDateTime(nacimiento);
            
            
            if (string.IsNullOrEmpty(TB_Nombre.Text)==false&& validacion.SoloLetras(TB_Nombre.Text)==true)//Esto hace las validaciones para ver si nada esta vacio
            {
                if (string.IsNullOrEmpty(TB_RFC.Text)==false&& validacion.NoEspacios(TB_RFC.Text)==true)
                {
                    if (string.IsNullOrEmpty(TB_CURP.Text) == false && validacion.NoEspacios(TB_CURP.Text)==true)
                    {
                        if (string.IsNullOrEmpty(TB_Usuario.Text) == false && validacion.NoEspacios(TB_Usuario.Text)==true)
                        {
                            if (string.IsNullOrEmpty(TB_Contraseña.Text) == false&&validacion.NoEspacios(TB_Usuario.Text)==true)
                            {
                                if (string.IsNullOrEmpty(nacimiento) == false)
                                {
                                    Conexion conexion = new Conexion();
                                    if (conexion.VerificarEmpleado(TB_Nombre.Text, TB_CURP.Text, TB_RFC.Text,TB_Usuario.Text) == true)//Verifica si no existe un empleado ya asi en la base de datos
                                    {
                                        conexion.InsertarNuevoEmpleado(TB_Nombre.Text, TB_CURP.Text, TB_RFC.Text, TB_Usuario.Text, TB_Contraseña.Text,Nacimiento,rightNow);
                                        this.Hide();
                                        MenuAltaEmpleados menuAltaEmpleados = new MenuAltaEmpleados();
                                        menuAltaEmpleados.Show();
                                    }
                                    else
                                    {
                                        Limpiar();
                                        MessageBox.Show("Este empleado ya existe,ingrese nueva informacion","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    Limpiar();
                                    MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                Limpiar();
                                MessageBox.Show("Debe Llenar todos los campos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            Limpiar();
                            MessageBox.Show("Debe Llenar todos los campos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        Limpiar();
                        MessageBox.Show("Debe Llenar todos los campos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Limpiar();
                    MessageBox.Show("Debe Llenar todos los campos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                Limpiar();
                MessageBox.Show("Debe Llenar todos los campos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {

        }
    }
}
