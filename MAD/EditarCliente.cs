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
    public partial class EditarCliente : Form
    {
        string CURPGlobal;
        public EditarCliente(string Nombre,string Password,string Sexo,string Colonia,string Calle,string NumCasa,string fechaNacimiento,string CURP,string UsuarioEmpleado)
        {
            InitializeComponent();
            ST_Usuario.Text = UsuarioEmpleado;
            CURPGlobal = CURP;
            TB_Nombre.Text = Nombre;
            TB_Calle.Text = Calle;
            TB_Colonia.Text = Colonia;
            TB_NumCasa.Text = NumCasa;
            TB_Password.Text = Password;
            DateTime fechaNacimientoData = Convert.ToDateTime(fechaNacimiento);
            DTP_Nacimiento.Value = fechaNacimientoData;
            if (string.Compare(Sexo, "Hombre")==0)
            {
                RB_Hombre.Checked=true;
                RB_Mujer.Checked = false;
            }
            else
            {
                RB_Hombre.Checked = false;
                RB_Mujer.Checked = true;
            }


        }
        public void Limpiar()
        {

        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            DateTime Nacimiento = DTP_Nacimiento.Value;
            DateTime dateTime = DateTime.Now;
            string nacimiento = Nacimiento.ToString("dd/MM/yyyy");
            Nacimiento = Convert.ToDateTime(nacimiento);
            if (string.IsNullOrEmpty(TB_Nombre.Text)==false && validacion.SoloLetras(TB_Nombre.Text)==true )
            {
                if (string.IsNullOrEmpty(TB_Calle.Text)==false)
                {
                    if (string.IsNullOrEmpty(TB_Colonia.Text)==false)
                    {
                        if(string.IsNullOrEmpty(TB_NumCasa.Text)==false&& validacion.soloNumeros(TB_NumCasa.Text) == true)
                        {
                            if (string.IsNullOrEmpty(nacimiento) == false)
                            {
                                if (string.IsNullOrEmpty(TB_Password.Text)==false&& validacion.NoEspacios(TB_Password.Text) == true)
                                {
                                    if(RB_Hombre.Checked==true && RB_Mujer.Checked == false)
                                    {
                                        Conexion conexion = new Conexion();
                                        if (conexion.verificacionInformacionUpdate(CURPGlobal) == true)
                                        {
                                            conexion.UpdateInformacionCliente(TB_Nombre.Text,TB_Password.Text,TB_NumCasa.Text,TB_Colonia.Text,TB_Calle.Text,"Hombre",Nacimiento,CURPGlobal);
                                            this.Hide();
                                            MenuClientes menuClientes = new MenuClientes(ST_Usuario.Text);
                                            menuClientes.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se logro encontrar al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else if(RB_Hombre.Checked==false&& RB_Mujer.Checked == true)
                                    {
                                        Conexion conexion = new Conexion();
                                        if (conexion.verificacionInformacionUpdate(CURPGlobal) == true)
                                        {
                                            conexion.UpdateInformacionCliente(TB_Nombre.Text, TB_Password.Text, TB_NumCasa.Text, TB_Colonia.Text, TB_Calle.Text, "Mujer", Nacimiento, CURPGlobal);
                                            this.Hide();
                                            MenuClientes menuClientes = new MenuClientes(ST_Usuario.Text);
                                            menuClientes.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se logro encontrar al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuClientes menuClientes = new MenuClientes(ST_Usuario.Text);
            menuClientes.Show();
        }
    }
}
