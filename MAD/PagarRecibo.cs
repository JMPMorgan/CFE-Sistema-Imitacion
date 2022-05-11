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
    public partial class PagarRecibo : Form
    {
        int verificacion = 0;//ESTO SE HACE PARA SABER AL MOMENTO DE PAGAR SI SE CREA UNA BUENA FORMA DE PAGO O SE ACTULIZA
        string debito, credito, efectivo, adeudo, pago,numeroReciboGlobla;

        private void BTN_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuRecibo menuRecibo = new MenuRecibo(ST_Usuario.Text);
            menuRecibo.Show();
        }

        public PagarRecibo(string fechaCreacion,string numeroMedidor,string consumoTotal,string tarifaBasica,string tarifaMedio,string tarifaExcedente,string numeroRecibo,string nombreTarifa,string Usuario)
        {
            InitializeComponent();
            ST_FechaCreacion.Text = fechaCreacion;
            ST_consumoTotal.Text = consumoTotal;
            ST_NumeroMedidor.Text = numeroMedidor;
            ST_Usuario.Text = Usuario;
            numeroReciboGlobla = numeroRecibo;
            Conexion conexion = new Conexion();
            if (conexion.verificarFormaPagotabla(numeroRecibo)==true)
            {
                verificacion = 1;
                List<string> formaPagoTabla = conexion.getInfoFormaPagoExistente(numeroRecibo);
                for (int i = 0; i < formaPagoTabla.Count; i++)
                {
                    if (i==0)
                    {
                        debito = formaPagoTabla[i];
                    }
                    else if (i==1)
                    {
                        credito = formaPagoTabla[i];
                    }
                    else if (i == 2)
                    {
                        efectivo = formaPagoTabla[i];
                    }
                    else if (i == 3)
                    {
                        adeudo = formaPagoTabla[i];
                    }
                    else if (i == 4)
                    {
                        pago = formaPagoTabla[i];
                    }
                }
                if (debito=="1")
                {
                    CB_metodoPago.Text = "Debito";
                }
                else if (credito=="1")
                {
                    CB_metodoPago.Text = "Credito";
                }
                else if (efectivo=="1")
                {
                    CB_metodoPago.Text = "Efectivo";
                }
                ST_adeudoTotal.Text = adeudo;
            }
            else
            {
                verificacion = 2;
                decimal consumoTotalf = Convert.ToDecimal(consumoTotal);
                decimal precioBasicof = Convert.ToDecimal(tarifaBasica);
                decimal precioMediof = Convert.ToDecimal(tarifaMedio);
                decimal precioExcedentef = Convert.ToDecimal(tarifaExcedente);
                decimal consumoBasicof = consumoTotalf / 4;
                decimal consumoMediof = consumoTotalf / 4;
                decimal consumoExcedentef = consumoTotalf / 2;
                decimal precioTotal;
                precioBasicof = consumoBasicof * precioBasicof;
                precioMediof = consumoMediof * precioMediof;
                precioExcedentef = consumoExcedentef * precioExcedentef;
                precioTotal = precioBasicof + precioMediof + precioExcedentef;
                double IVA = .16;
                decimal precioIVA = Convert.ToDecimal(IVA);
                decimal precioTotalIVA = precioTotal + (precioTotal * precioIVA);
                ST_adeudoTotal.Text = Convert.ToString(precioTotalIVA);
                CB_metodoPago.Items.Add("Efectivo");
                CB_metodoPago.Items.Add("Credito");
                CB_metodoPago.Items.Add("Debito");
            }

        }

        private void PagarRecibo_Load(object sender, EventArgs e)
        {

        }

        private void BTN_pagar_Click(object sender, EventArgs e)
        {
            Validaciones.Validacion validacion = new Validaciones.Validacion();
            if (string.IsNullOrEmpty(CB_metodoPago.Text) == false)
            {
                if (string.IsNullOrEmpty(TB_ingreseCantidad.Text)==false && validacion.soloNumerosPunto(TB_ingreseCantidad.Text)==true)
                {
                    pago = TB_ingreseCantidad.Text;
                    decimal adeudod = Convert.ToDecimal(ST_adeudoTotal.Text);
                    decimal pagoD = Convert.ToDecimal(pago);
                    adeudod = adeudod - pagoD;
                    pago = Convert.ToString(pagoD);
                    adeudo = Convert.ToString(adeudod);


                    if (CB_metodoPago.Text=="Debito")
                    {
                        debito = "1";
                        credito = "0";
                        efectivo = "0";
                    }
                    else if (CB_metodoPago.Text == "Credito")
                    {
                        debito = "0";
                        credito = "1";
                        efectivo = "0";
                    }
                    else if (CB_metodoPago.Text == "Efectivo")
                    {
                        debito = "0";
                        credito = "0";
                        efectivo = "1";
                    }
                    Conexion conexion = new Conexion();
                    if (verificacion==2)
                    {
                        conexion.insertarFormaPago(debito,credito,efectivo,adeudo,pago,numeroReciboGlobla);
                        this.Hide();
                        MenuRecibo menuRecibo = new MenuRecibo(ST_Usuario.Text);
                        menuRecibo.Show();
                    }
                    else if (verificacion==1)
                    {
                        conexion.updateFormaPago(debito, credito, efectivo, adeudo, pago, numeroReciboGlobla);
                        this.Hide();
                        MenuRecibo menuRecibo = new MenuRecibo(ST_Usuario.Text);
                        menuRecibo.Show();
                    }
                }
            }
        }
    }
}
