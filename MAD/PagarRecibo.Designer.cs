
namespace MAD
{
    partial class PagarRecibo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB_metodoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ingreseCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ST_FechaCreacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ST_NumeroMedidor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ST_consumoTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ST_adeudoTotal = new System.Windows.Forms.Label();
            this.BTN_pagar = new System.Windows.Forms.Button();
            this.BTN_regresar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ST_Usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_metodoPago
            // 
            this.CB_metodoPago.FormattingEnabled = true;
            this.CB_metodoPago.Location = new System.Drawing.Point(12, 25);
            this.CB_metodoPago.Name = "CB_metodoPago";
            this.CB_metodoPago.Size = new System.Drawing.Size(121, 21);
            this.CB_metodoPago.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escoga el metodo de pago";
            // 
            // TB_ingreseCantidad
            // 
            this.TB_ingreseCantidad.Location = new System.Drawing.Point(157, 25);
            this.TB_ingreseCantidad.Name = "TB_ingreseCantidad";
            this.TB_ingreseCantidad.Size = new System.Drawing.Size(113, 20);
            this.TB_ingreseCantidad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese la cantidad";
            // 
            // ST_FechaCreacion
            // 
            this.ST_FechaCreacion.AutoSize = true;
            this.ST_FechaCreacion.Location = new System.Drawing.Point(295, 9);
            this.ST_FechaCreacion.Name = "ST_FechaCreacion";
            this.ST_FechaCreacion.Size = new System.Drawing.Size(35, 13);
            this.ST_FechaCreacion.TabIndex = 4;
            this.ST_FechaCreacion.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Creacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero de Medidor";
            // 
            // ST_NumeroMedidor
            // 
            this.ST_NumeroMedidor.AutoSize = true;
            this.ST_NumeroMedidor.Location = new System.Drawing.Point(295, 58);
            this.ST_NumeroMedidor.Name = "ST_NumeroMedidor";
            this.ST_NumeroMedidor.Size = new System.Drawing.Size(35, 13);
            this.ST_NumeroMedidor.TabIndex = 6;
            this.ST_NumeroMedidor.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Consumo Total";
            // 
            // ST_consumoTotal
            // 
            this.ST_consumoTotal.AutoSize = true;
            this.ST_consumoTotal.Location = new System.Drawing.Point(295, 108);
            this.ST_consumoTotal.Name = "ST_consumoTotal";
            this.ST_consumoTotal.Size = new System.Drawing.Size(35, 13);
            this.ST_consumoTotal.TabIndex = 8;
            this.ST_consumoTotal.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adeudo Total";
            // 
            // ST_adeudoTotal
            // 
            this.ST_adeudoTotal.AutoSize = true;
            this.ST_adeudoTotal.Location = new System.Drawing.Point(295, 168);
            this.ST_adeudoTotal.Name = "ST_adeudoTotal";
            this.ST_adeudoTotal.Size = new System.Drawing.Size(35, 13);
            this.ST_adeudoTotal.TabIndex = 10;
            this.ST_adeudoTotal.Text = "label3";
            // 
            // BTN_pagar
            // 
            this.BTN_pagar.Location = new System.Drawing.Point(380, 415);
            this.BTN_pagar.Name = "BTN_pagar";
            this.BTN_pagar.Size = new System.Drawing.Size(75, 23);
            this.BTN_pagar.TabIndex = 12;
            this.BTN_pagar.Text = "Pagar";
            this.BTN_pagar.UseVisualStyleBackColor = true;
            this.BTN_pagar.Click += new System.EventHandler(this.BTN_pagar_Click);
            // 
            // BTN_regresar
            // 
            this.BTN_regresar.Location = new System.Drawing.Point(12, 415);
            this.BTN_regresar.Name = "BTN_regresar";
            this.BTN_regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_regresar.TabIndex = 13;
            this.BTN_regresar.Text = "Regresar";
            this.BTN_regresar.UseVisualStyleBackColor = true;
            this.BTN_regresar.Click += new System.EventHandler(this.BTN_regresar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Usuario:";
            // 
            // ST_Usuario
            // 
            this.ST_Usuario.AutoSize = true;
            this.ST_Usuario.Location = new System.Drawing.Point(141, 414);
            this.ST_Usuario.Name = "ST_Usuario";
            this.ST_Usuario.Size = new System.Drawing.Size(35, 13);
            this.ST_Usuario.TabIndex = 14;
            this.ST_Usuario.Text = "label3";
            // 
            // PagarRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ST_Usuario);
            this.Controls.Add(this.BTN_regresar);
            this.Controls.Add(this.BTN_pagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ST_adeudoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ST_consumoTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ST_NumeroMedidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ST_FechaCreacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_ingreseCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_metodoPago);
            this.Name = "PagarRecibo";
            this.Text = "PagarRecibo";
            this.Load += new System.EventHandler(this.PagarRecibo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_metodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ingreseCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ST_FechaCreacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ST_NumeroMedidor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ST_consumoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ST_adeudoTotal;
        private System.Windows.Forms.Button BTN_pagar;
        private System.Windows.Forms.Button BTN_regresar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ST_Usuario;
    }
}