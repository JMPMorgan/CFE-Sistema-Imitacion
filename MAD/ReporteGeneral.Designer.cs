
namespace MAD
{
    partial class ReporteGeneral
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
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.BTN_PDF = new System.Windows.Forms.Button();
            this.TB_IngresarCURP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Año = new System.Windows.Forms.ComboBox();
            this.TB_Servicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_MesBusqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LT_Usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 93);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 0;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_PDF
            // 
            this.BTN_PDF.Location = new System.Drawing.Point(572, 93);
            this.BTN_PDF.Name = "BTN_PDF";
            this.BTN_PDF.Size = new System.Drawing.Size(75, 23);
            this.BTN_PDF.TabIndex = 1;
            this.BTN_PDF.Text = "Crear PDF";
            this.BTN_PDF.UseVisualStyleBackColor = true;
            this.BTN_PDF.Click += new System.EventHandler(this.BTN_PDF_Click);
            // 
            // TB_IngresarCURP
            // 
            this.TB_IngresarCURP.Location = new System.Drawing.Point(13, 13);
            this.TB_IngresarCURP.Name = "TB_IngresarCURP";
            this.TB_IngresarCURP.Size = new System.Drawing.Size(128, 20);
            this.TB_IngresarCURP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar CURP Cliente";
            // 
            // CB_Año
            // 
            this.CB_Año.FormattingEnabled = true;
            this.CB_Año.Location = new System.Drawing.Point(414, 11);
            this.CB_Año.Name = "CB_Año";
            this.CB_Año.Size = new System.Drawing.Size(121, 21);
            this.CB_Año.TabIndex = 7;
            // 
            // TB_Servicio
            // 
            this.TB_Servicio.Location = new System.Drawing.Point(308, 12);
            this.TB_Servicio.Name = "TB_Servicio";
            this.TB_Servicio.Size = new System.Drawing.Size(100, 20);
            this.TB_Servicio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de Servicio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TB_MesBusqueda
            // 
            this.TB_MesBusqueda.Location = new System.Drawing.Point(148, 12);
            this.TB_MesBusqueda.Name = "TB_MesBusqueda";
            this.TB_MesBusqueda.Size = new System.Drawing.Size(154, 20);
            this.TB_MesBusqueda.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingresar Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingresar Año ";
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(542, 9);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Buscar.TabIndex = 13;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Usuario:";
            // 
            // LT_Usuario
            // 
            this.LT_Usuario.AutoSize = true;
            this.LT_Usuario.Location = new System.Drawing.Point(135, 103);
            this.LT_Usuario.Name = "LT_Usuario";
            this.LT_Usuario.Size = new System.Drawing.Size(71, 13);
            this.LT_Usuario.TabIndex = 15;
            this.LT_Usuario.Text = "usuarioActual";
            // 
            // ReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 128);
            this.Controls.Add(this.LT_Usuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_MesBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Año);
            this.Controls.Add(this.TB_Servicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_IngresarCURP);
            this.Controls.Add(this.BTN_PDF);
            this.Controls.Add(this.BTN_Regresar);
            this.Name = "ReporteGeneral";
            this.Text = "ReporteGeneral";
            this.Load += new System.EventHandler(this.ReporteGeneral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_PDF;
        private System.Windows.Forms.TextBox TB_IngresarCURP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Año;
        private System.Windows.Forms.TextBox TB_Servicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_MesBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LT_Usuario;
    }
}