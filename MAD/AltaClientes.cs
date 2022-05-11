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
    public partial class AltaClientes : Form
    {
        public AltaClientes(string UsuarioEmpleado)
        {
            InitializeComponent();
            ST_Usuario.Text = UsuarioEmpleado;
        }

        public void limpiar()
        {
            TB_Calle.Text = "";
            TB_Colonia.Text = "";
            TB_CURP.Text = "";
            TB_Email.Text = "";
            TB_Nombre.Text = "";
            TB_NumCasa.Text = "";
            TB_Password.Text = "";
            RB_Hombre.Checked = false;
            RB_Mujer.Checked = false;
        }
        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            MC_Nacimiento.MaxSelectionCount = 1;
            DateTime Nacimiento = MC_Nacimiento.SelectionRange.Start;
            DateTime dateTime = DateTime.Now;
            string nacimiento = Nacimiento.ToString("dd/MM/yyyy");
            
            if(string.IsNullOrEmpty(TB_Nombre.Text)==false && validacion.SoloLetras(TB_Nombre.Text) == true)
            {
                if(string.IsNullOrEmpty(TB_Email.Text)==false&& validacion.email(TB_Email.Text)==true  && string.IsNullOrWhiteSpace(TB_Email.Text) == false)
                {
                    if (string.IsNullOrEmpty(TB_CURP.Text)==false && validacion.SoloLetrasOficial(TB_CURP.Text)==true)
                    {
                        if (string.IsNullOrEmpty(TB_Calle.Text) == false)
                        {
                            if (string.IsNullOrEmpty(TB_Colonia.Text) == false)
                            {
                                if(string.IsNullOrEmpty(TB_NumCasa.Text)==false && validacion.soloNumeros(TB_NumCasa.Text) == true)
                                {
                                    if(string.IsNullOrEmpty(TB_Password.Text)==false && validacion.NoEspacios(TB_Password.Text) == true)
                                    {

                                        if (RB_Hombre.Checked == true && RB_Mujer.Checked == false)
                                        {
                                            if (string.IsNullOrEmpty(nacimiento) == false)
                                            {
                                                Conexion conexion = new Conexion();
                                                if (conexion.verificarCliente(TB_CURP.Text,TB_Password.Text,TB_Email.Text) == true)
                                                {
                                                    conexion.InsertarNuevoCliente(TB_Nombre.Text, TB_CURP.Text, TB_Email.Text, TB_Password.Text, TB_Colonia.Text, TB_Calle.Text, TB_NumCasa.Text, Nacimiento, dateTime, RB_Hombre.Text);
                                                    this.Hide();
                                                    MenuClientes menuClientes = new MenuClientes(ST_Usuario.Text);
                                                    menuClientes.Show();
                                                }
                                                else
                                                {
                                                    limpiar();
                                                    MessageBox.Show("Este cliente ya existe,ingrese nueva informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                limpiar();
                                            }
                                        }
                                        else if (RB_Hombre.Checked == false && RB_Mujer.Checked == true)
                                        {
                                            if (string.IsNullOrEmpty(nacimiento) == false)
                                            {
                                                Conexion conexion = new Conexion();
                                                if (conexion.verificarCliente(TB_CURP.Text,TB_Password.Text,TB_Email.Text) == true)
                                                {
                                                    conexion.InsertarNuevoCliente(TB_Nombre.Text, TB_CURP.Text, TB_Email.Text, TB_Password.Text, TB_Colonia.Text, TB_Calle.Text, TB_NumCasa.Text, Nacimiento, dateTime, RB_Mujer.Text);
                                                    this.Hide();
                                                    MenuClientes menuClientes = new MenuClientes(ST_Usuario.Text);
                                                    menuClientes.Show();
                                                }
                                                else
                                                {
                                                    limpiar();
                                                    MessageBox.Show("Este cliente ya existe,ingrese nueva informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                limpiar();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            limpiar();
                                        }


                                    }

                                    else
                                    {
                                        MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        limpiar();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    limpiar();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                limpiar();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiar();
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
