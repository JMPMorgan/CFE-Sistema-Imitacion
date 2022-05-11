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
    public partial class MenuConsumos : Form
    {
        string valoresCelda;
        string numeroServicio, CURPCliente, direccionCasa, UserEmpleado, UsuarioCliente,fechaCreacion;
        public MenuConsumos(string Usuario)
        {
            InitializeComponent();
            LB_Usuario.Text = Usuario;
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valoresCelda)==false)
            {
                Conexion conexion = new Conexion();

                if (conexion.existeAlgunCliente(valoresCelda)==true&&conexion.existeAlgunClienteParaConsumos(TB_Buscar.Text)==true)
                {
                    List<string>info=conexion.GetInfoClienteParaConsumo(TB_Buscar.Text,valoresCelda);
                    for (int i = 0; i < info.Count; i++)
                    {
                        if (i==0)
                        {
                            numeroServicio = info[i];
                        }
                        else if(i==1){
                            CURPCliente = info[i];
                        }
                        else if (i == 2)
                        {
                            direccionCasa = info[i];
                        }
                        else if (i == 3)
                        {
                            UserEmpleado = info[i];
                        }
                        else if (i==4)
                        {
                            fechaCreacion = info[i];
                        }
                        else if (i == 5)
                        {
                            UsuarioCliente = info[i];
                        }
                    }
                    this.Hide();
                    AñadirConsumo añadirConsumo = new AñadirConsumo(fechaCreacion,numeroServicio,valoresCelda,UserEmpleado,CURPCliente,direccionCasa,UsuarioCliente,LB_Usuario.Text);
                    añadirConsumo.Show();

                }
            }
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuEmpleados menuEmpleados = new MenuEmpleados(LB_Usuario.Text);
            menuEmpleados.Show();
        }

        private void DTG_AllContratosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valoresCelda = DTG_AllContratosCliente.CurrentRow.Cells["numeroMedidor"].Value.ToString();
        }

        private void MenuConsumos_Load(object sender, EventArgs e)
        {

        }

        private void TB_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Buscar.Text) == false || string.IsNullOrWhiteSpace(TB_Buscar.Text) == false)
            {
                Conexion conexion = new Conexion();
                DTG_AllContratosCliente.DataSource = conexion.MostrarAllContratosConsumo(TB_Buscar.Text);
            }
        }
    }
}
