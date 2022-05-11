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
    public partial class Form1 : Form
    {
        int errorsesion = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public  struct  usuario
        {
           public string User;
           public string Password;
        }

        private void BTN_Entrar_Click(object sender, EventArgs e)
        {   

            usuario usuario = new usuario();
            usuario.User = TB_Usuario.Text;
            usuario.Password = TB_Password.Text;
            Conexion conexion = new Conexion();
            if(string.Compare(usuario.User,"Admi")==0)
            {
                if (string.Compare(usuario.Password, "1234") == 0)
                {
                    errorsesion = 0;
                    this.Hide();
                    MenuAltaEmpleados menuAltaEmpleados = new MenuAltaEmpleados();
                    menuAltaEmpleados.Show();
                }
            }
            else if(conexion.inicioSesionEmpleado(TB_Usuario.Text,TB_Password.Text)==true && errorsesion <3)
            {
                this.Hide();
                MenuEmpleados menuEmpleados = new MenuEmpleados(TB_Usuario.Text);
                menuEmpleados.Show();
            }
            else if (conexion.inicioSesionClientes(TB_Usuario.Text,TB_Password.Text)== true && errorsesion < 3)
            {
                this.Hide();
                MenuClientesSesion menuClientes = new MenuClientesSesion();
                menuClientes.Show();
            }
            else
            {
                MessageBox.Show("No se encontro ningun Usuario, Verifique e Ingrese de nuevo la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TB_Usuario.Text = "";
                TB_Password.Text = "";
                errorsesion++;
            }
            
        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
