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
    public partial class EditarEmpleado : Form
    {
        string curpGlobal;
        string rfcGlobal;
        string usuarioGlobal;
        string passwordGlobal;
        string nombreEmpleadoGlobal;
        string fechaNacimientoGlobal;
        public EditarEmpleado(string CURP ,string RFC ,string Usuario,string password,string nombreEmpleado,string fechaNacimiento) 
        {
            InitializeComponent();
            TB_Nombre.Text = nombreEmpleado;
            TB_RFC.Text = RFC;
            TB_Contraseña.Text = password;
            DateTime fechaNacimientoData = Convert.ToDateTime(fechaNacimiento);
            DTP_Nacimiento.Value = fechaNacimientoData;
            curpGlobal = CURP;
            rfcGlobal = RFC;
            usuarioGlobal = Usuario;
            passwordGlobal = password;
            nombreEmpleadoGlobal = nombreEmpleado;
            fechaNacimientoGlobal = fechaNacimiento;
        }
        public void Limpiar()//Limpia los textbox
        {
            TB_Nombre.Text = "";
            TB_RFC.Text = "";
            TB_Contraseña.Text = "";
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Guradar_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            DateTime Nacimiento = DTP_Nacimiento.Value;
            DateTime dateTime = DateTime.Now;
            string nacimiento = Nacimiento.ToString("dd/MM/yyyy");
            Nacimiento = Convert.ToDateTime(nacimiento);
            if (string.IsNullOrEmpty(TB_Nombre.Text) == false && validacion.SoloLetras(TB_Nombre.Text) == true)//Esto hace las validaciones para ver si nada esta vacio
            {
                        if (string.IsNullOrEmpty(TB_RFC.Text) == false && validacion.NoEspacios(TB_RFC.Text) == true)
                        {
                            if (string.IsNullOrEmpty(TB_Contraseña.Text) == false && validacion.NoEspacios(TB_Contraseña.Text) == true)
                            {
                                if (string.IsNullOrEmpty(nacimiento) == false)
                                {
                                    Conexion conexion = new Conexion();
                                    if (conexion.verificaInformacionUpdte(curpGlobal,usuarioGlobal,nombreEmpleadoGlobal,rfcGlobal,passwordGlobal,Nacimiento)==true)//Verifica si no existe un empleado ya asi en la base de datos
                                    {
                                        conexion.UpdateInformacionEmpleado(TB_Nombre.Text,TB_Contraseña.Text,TB_RFC.Text,Nacimiento,curpGlobal,usuarioGlobal);
                                        this.Hide();
                                        MenuAltaEmpleados menuAltaEmpleados = new MenuAltaEmpleados();
                                        menuAltaEmpleados.Show();
                                    }
                                    else
                                    {
                                        Limpiar();
                                        MessageBox.Show("No se logro encontrar al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
