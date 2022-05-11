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
    public partial class NuevaTarifa : Form
    {
        public NuevaTarifa(string UsuarioActual)
        {
            InitializeComponent();
            ST_Usuario.Text = UsuarioActual;
        }
        public void limpiar()
        {
            TB_Nombre.Text = "";
            TB_Intermedio.Text = "";
            TB_Excedente.Text = "";
            TB_Basica.Text = "";
        }
        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            if(string.IsNullOrEmpty(TB_Nombre.Text)==false && validacion.SoloLetrasOficial(TB_Nombre.Text) == true)
            {
                if (string.IsNullOrEmpty(TB_Basica.Text)==false && string.IsNullOrWhiteSpace(TB_Basica.Text)==false && validacion.soloNumeros(TB_Basica.Text) == true)
                {
                    if (string.IsNullOrEmpty(TB_Intermedio.Text) == false && string.IsNullOrWhiteSpace(TB_Intermedio.Text) == false && validacion.soloNumeros(TB_Intermedio.Text) == true)
                    {
                        if (string.IsNullOrEmpty(TB_Excedente.Text) == false && string.IsNullOrWhiteSpace(TB_Excedente.Text) == false && validacion.soloNumeros(TB_Excedente.Text) == true)
                        {
                            Conexion conexion = new Conexion();
                            if (conexion.checkTarifa(TB_Nombre.Text)==true)
                            {
                                int Basica = Convert.ToInt32(TB_Basica.Text);
                                int Intermedio = Convert.ToInt32(TB_Intermedio.Text);
                                int Excedente = Convert.ToInt32(TB_Excedente.Text);
                                conexion.InsertarNuevaTarifa(TB_Nombre.Text, Basica, Intermedio, Excedente, ST_Usuario.Text);
                                this.Hide();
                                MenuTarifas menuTarifas = new MenuTarifas(ST_Usuario.Text);
                                menuTarifas.Show();
                            }
                            else
                            {
                                limpiar();
                                MessageBox.Show("El nombre de tarifa ya existe ingrese una nueva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            limpiar();
                            MessageBox.Show("Error al ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        limpiar();
                        MessageBox.Show("Error al ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    limpiar();
                    MessageBox.Show("Error al ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                limpiar();
                MessageBox.Show("Error al ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuTarifas menuTarifas = new MenuTarifas(ST_Usuario.Text);
            menuTarifas.Show();
        }
    }
}
