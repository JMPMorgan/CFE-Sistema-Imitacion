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
    public partial class AñadirConsumo : Form
    {
        string numeroMedidorGlobal;
        public AñadirConsumo(string fechaCreacion,string numeroServicio,string numeroMedidor,string UserEmpleado,string CURPCliente,string direccionCasa,string UsuarioCliente,string UserActual)
        {
            InitializeComponent();
            LT_NombreCliente.Text = CURPCliente;
            LT_Email.Text =UsuarioCliente;
            LT_DireccionContrato.Text= direccionCasa;
            LT_TipoContrato.Text = numeroServicio;
            LT_Empleado.Text = UserEmpleado;
            DTP_MesInicio.Value = Convert.ToDateTime(fechaCreacion);
            numeroMedidorGlobal = numeroMedidor;
            LB_UsuarioActual.Text = UserActual;
        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            if (string.IsNullOrEmpty(DTP_MesInicio.Value.ToString())==false)
            {
                if (string.IsNullOrEmpty(TB_CargarConsumo.Text)==false && validacion.soloNumeros(TB_CargarConsumo.Text)==true)
                {
                    if (string.IsNullOrEmpty(CB_Tarifas.Text) == false)
                    {
                        Conexion conexion = new Conexion();
                        if (conexion.checkFechaContrato(DTP_MesInicio.Value, numeroMedidorGlobal,LT_TipoContrato.Text) == true)//Comprobacion para saber si el tiempo que paso coincide con el metodo de contrato
                        {
                            if (conexion.checkMesIngreso(DTP_MesInicio.Value,LT_TipoContrato.Text) == true)//Comprobacion para saber si ya se ingreso el consumo en ese mes
                            {
                                conexion.agregarConsumo(DTP_MesInicio.Value, TB_CargarConsumo.Text, CB_Tarifas.Text, numeroMedidorGlobal);
                                conexion.agregarRecibo(LT_TipoContrato.Text, LT_Empleado.Text, TB_CargarConsumo.Text, CB_Tarifas.Text, numeroMedidorGlobal, DTP_MesInicio.Value);
                                this.Hide();
                                MenuConsumos menuConsumos = new MenuConsumos(LB_UsuarioActual.Text);
                                menuConsumos.Show();
                            }
                            else
                            {
                                MessageBox.Show("Ingrese un valor siguiente de consumo este mes ya ha sido rellenado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un valor siguiente de consumo este mes ya ha sido rellenado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            //conexion.insertNuevoConsumo();
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuConsumos menuConsumos = new MenuConsumos(LB_UsuarioActual.Text);
            menuConsumos.Show();
        }

        private void TB_CargarConsumo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AñadirConsumo_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
           if (conexion.existeAlgunaTarifaParaConsumo()==true)
           {
                conexion.mandarAComboBoxConsumo(CB_Tarifas);
           }
        }
    }
}
