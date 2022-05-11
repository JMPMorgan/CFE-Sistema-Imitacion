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
    public partial class NuevoContrato : Form
    {
        public NuevoContrato(string Nombre, string Direccion,string Usuario,string CURP,string UsuarioEmpleado)
        {
            InitializeComponent();
            ST_Nombre.Text = Nombre;
            ST_Email.Text = Usuario;
            ST_Direccion.Text = Direccion;
            ST_CURP.Text = CURP;
            ST_Usuario.Text = UsuarioEmpleado;
        }

        public void limpiar()
        {
            TB_Colonia.Text = "";
            TB_Calle.Text = "";
            TB_EntreCalles.Text = "";
            TB_NumeroCasa.Text = "";
            RB_Domestico.Checked = false;
            RB_Industrial.Checked = false;
        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Colonia.Text)==false )
            {
                if (string.IsNullOrEmpty(TB_Calle.Text)==false)
                {
                    if (string.IsNullOrEmpty(TB_EntreCalles.Text) == false)
                    {
                        if(string.IsNullOrEmpty(TB_NumeroCasa.Text)==false&& string.IsNullOrWhiteSpace(TB_NumeroCasa.Text) == false)
                        {
                            Conexion conexion = new Conexion();
                            string direccionCasa = TB_Colonia.Text + " " + TB_Calle.Text + " " + TB_NumeroCasa.Text;
                            if (conexion.checkContrato(direccionCasa, TB_EntreCalles.Text) == true)
                            {
                                if (RB_Domestico.Checked==true && RB_Industrial.Checked==false)
                                {
                                    DateTime rightNow = DateTime.Now;
                                    int NumeroContrato = conexion.ObtenerLastId();
                                    conexion.InsertarNuevoContrato(rightNow,"1",NumeroContrato,ST_CURP.Text,direccionCasa,TB_EntreCalles.Text,ST_Usuario.Text);
                                    this.Hide();
                                    MenuContratos menuContratos = new MenuContratos(ST_Usuario.Text);
                                    menuContratos.Show();
                                }
                                else if (RB_Domestico.Checked == false && RB_Industrial.Checked == true)
                                {
                                    DateTime rightNow = DateTime.Now;
                                    int NumeroContrato = conexion.ObtenerLastId();
                                    conexion.InsertarNuevoContrato(rightNow,"2",NumeroContrato,ST_CURP.Text,direccionCasa,TB_EntreCalles.Text,ST_Usuario.Text);
                                    this.Hide();
                                    MenuContratos menuContratos = new MenuContratos(ST_Usuario.Text);
                                    menuContratos.Show();
                                }
                                else
                                {
                                    limpiar();
                                    MessageBox.Show("Escoga el tipo de servicio que desea el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                limpiar();
                                MessageBox.Show("Ya existe un contrato en esta localidad,ingrese una nueva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            limpiar();
                            MessageBox.Show("Debe Rellanar la informacion,no espacios y ingrese Informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        limpiar();
                        MessageBox.Show("Debe Rellanar la informacion,no espacios y ingrese Informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    limpiar();
                    MessageBox.Show("Debe Rellanar la informacion,no espacios y ingrese Informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                limpiar();
                MessageBox.Show("Debe Rellanar la informacion,no espacios y ingrese Informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuContratos menuContratos = new MenuContratos(ST_Usuario.Text);
            menuContratos.Show();
        }

        private void NuevoContrato_Load(object sender, EventArgs e)
        {

        }
    }
}
