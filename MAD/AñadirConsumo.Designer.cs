
namespace MAD
{
    partial class AñadirConsumo
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
            this.LT_NombreCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LT_Email = new System.Windows.Forms.Label();
            this.DTP_MesInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_CargarConsumo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.CB_Tarifas = new System.Windows.Forms.ComboBox();
            this.LT_TipoContrato = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LT_DireccionContrato = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LT_Empleado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_UsuarioActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LT_NombreCliente
            // 
            this.LT_NombreCliente.AutoSize = true;
            this.LT_NombreCliente.Location = new System.Drawing.Point(13, 13);
            this.LT_NombreCliente.Name = "LT_NombreCliente";
            this.LT_NombreCliente.Size = new System.Drawing.Size(95, 13);
            this.LT_NombreCliente.TabIndex = 0;
            this.LT_NombreCliente.Text = "LT_NombreCliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CURP del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            // 
            // LT_Email
            // 
            this.LT_Email.AutoSize = true;
            this.LT_Email.Location = new System.Drawing.Point(13, 57);
            this.LT_Email.Name = "LT_Email";
            this.LT_Email.Size = new System.Drawing.Size(51, 13);
            this.LT_Email.TabIndex = 2;
            this.LT_Email.Text = "LT_Email";
            // 
            // DTP_MesInicio
            // 
            this.DTP_MesInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_MesInicio.Location = new System.Drawing.Point(188, 26);
            this.DTP_MesInicio.Name = "DTP_MesInicio";
            this.DTP_MesInicio.Size = new System.Drawing.Size(200, 20);
            this.DTP_MesInicio.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Escoga el mes de consumo";
            // 
            // TB_CargarConsumo
            // 
            this.TB_CargarConsumo.Location = new System.Drawing.Point(188, 194);
            this.TB_CargarConsumo.Name = "TB_CargarConsumo";
            this.TB_CargarConsumo.Size = new System.Drawing.Size(137, 20);
            this.TB_CargarConsumo.TabIndex = 14;
            this.TB_CargarConsumo.TextChanged += new System.EventHandler(this.TB_CargarConsumo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cargar Consumo";
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 401);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 16;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.Location = new System.Drawing.Point(313, 406);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Guardar.TabIndex = 17;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = true;
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // CB_Tarifas
            // 
            this.CB_Tarifas.FormattingEnabled = true;
            this.CB_Tarifas.Location = new System.Drawing.Point(188, 234);
            this.CB_Tarifas.Name = "CB_Tarifas";
            this.CB_Tarifas.Size = new System.Drawing.Size(200, 21);
            this.CB_Tarifas.TabIndex = 18;
            // 
            // LT_TipoContrato
            // 
            this.LT_TipoContrato.AutoSize = true;
            this.LT_TipoContrato.Location = new System.Drawing.Point(12, 147);
            this.LT_TipoContrato.Name = "LT_TipoContrato";
            this.LT_TipoContrato.Size = new System.Drawing.Size(87, 13);
            this.LT_TipoContrato.TabIndex = 10;
            this.LT_TipoContrato.Text = "LT_TipoContrato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo de Contrato";
            // 
            // LT_DireccionContrato
            // 
            this.LT_DireccionContrato.AutoSize = true;
            this.LT_DireccionContrato.Location = new System.Drawing.Point(13, 102);
            this.LT_DireccionContrato.Name = "LT_DireccionContrato";
            this.LT_DireccionContrato.Size = new System.Drawing.Size(101, 13);
            this.LT_DireccionContrato.TabIndex = 4;
            this.LT_DireccionContrato.Text = "LT_ColoniaContrato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Colonia del Contrato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Empleado Realizador";
            // 
            // LT_Empleado
            // 
            this.LT_Empleado.AutoSize = true;
            this.LT_Empleado.Location = new System.Drawing.Point(13, 188);
            this.LT_Empleado.Name = "LT_Empleado";
            this.LT_Empleado.Size = new System.Drawing.Size(35, 13);
            this.LT_Empleado.TabIndex = 19;
            this.LT_Empleado.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Usuario:";
            // 
            // LB_UsuarioActual
            // 
            this.LB_UsuarioActual.AutoSize = true;
            this.LB_UsuarioActual.Location = new System.Drawing.Point(133, 406);
            this.LB_UsuarioActual.Name = "LB_UsuarioActual";
            this.LB_UsuarioActual.Size = new System.Drawing.Size(71, 13);
            this.LB_UsuarioActual.TabIndex = 22;
            this.LB_UsuarioActual.Text = "usuarioActual";
            // 
            // AñadirConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 436);
            this.Controls.Add(this.LB_UsuarioActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LT_Empleado);
            this.Controls.Add(this.CB_Tarifas);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_CargarConsumo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DTP_MesInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LT_TipoContrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LT_DireccionContrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LT_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LT_NombreCliente);
            this.Name = "AñadirConsumo";
            this.Text = "AñadirConsumo";
            this.Load += new System.EventHandler(this.AñadirConsumo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LT_NombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LT_Email;
        private System.Windows.Forms.DateTimePicker DTP_MesInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_CargarConsumo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.ComboBox CB_Tarifas;
        private System.Windows.Forms.Label LT_TipoContrato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LT_DireccionContrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LT_Empleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_UsuarioActual;
    }
}