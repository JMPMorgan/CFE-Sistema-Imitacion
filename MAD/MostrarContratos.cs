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
    public partial class MostrarContratos : Form
    {
        string CURPGlobal;
        string valoresCelda;
        string fechaCreacion, numeroServicio, NumeroMedidor, numeroContrato, UserEmpleado, CURPCliente,
        direccionCasa, entreCalles;
        public MostrarContratos(string CURPCliente,string UsuarioEmpleado)
        {
            InitializeComponent();
            ST_Usuario.Text = UsuarioEmpleado;
            CURPGlobal = CURPCliente;
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuContratos menuContratos = new MenuContratos(ST_Usuario.Text);
            menuContratos.Show();
        }

        private void DTG_AllContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valoresCelda = DTG_AllContratos.CurrentRow.Cells["numeroMedidor"].Value.ToString();
            int numeroMedidor = Convert.ToInt32(valoresCelda);
            Conexion conexion = new Conexion();
            if (conexion.verificarContratoEnMostrarContrato(numeroMedidor)==true)
            {
                List<string> lista = conexion.ObtenerInfoContratosMostrar(numeroMedidor);
                for (int i = 0; i < lista.Count; i++)
                {
                    if (i==0)
                    {
                        fechaCreacion = lista[i];

                    }
                    else if (i == 1)
                    {
                        numeroServicio = lista[i];
                    }
                    else if (i == 2)
                    {
                        NumeroMedidor = lista[i];
                    }
                    else if (i == 3)
                    {
                        numeroContrato = lista[i];
                    }
                    else if (i == 4)
                    {
                        UserEmpleado = lista[i];
                    }
                    else if (i == 5)
                    {
                        CURPCliente = lista[i];
                    }
                    else if (i == 6)
                    {
                        direccionCasa = lista[i];
                    }
                    else if (i==7)
                    {
                        entreCalles = lista[i];
                    }
                }
                this.Hide();
                MostrarInfoContrato mostrarInfoContrato = new MostrarInfoContrato(fechaCreacion,numeroServicio,NumeroMedidor,numeroContrato,UserEmpleado,CURPCliente,direccionCasa,entreCalles,ST_Usuario.Text);
                mostrarInfoContrato.Show();
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el Contrato para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarContratos_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CURPGlobal) == false)
            {
                Conexion conexion = new Conexion();
                DTG_AllContratos.DataSource = conexion.MostrarAllContratos(CURPGlobal);
            }
        }
    }
}
