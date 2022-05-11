
namespace MAD
{
    partial class MenuRecibo
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
            this.TB_NumeroRecibo = new System.Windows.Forms.TextBox();
            this.TB_MesInicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.BTN_VerRecibo = new System.Windows.Forms.Button();
            this.DTG_AllRecibos = new System.Windows.Forms.DataGridView();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_Usuario = new System.Windows.Forms.Label();
            this.BTN_Pagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_NumeroRecibo
            // 
            this.TB_NumeroRecibo.Location = new System.Drawing.Point(13, 13);
            this.TB_NumeroRecibo.Name = "TB_NumeroRecibo";
            this.TB_NumeroRecibo.Size = new System.Drawing.Size(148, 20);
            this.TB_NumeroRecibo.TabIndex = 0;
            this.TB_NumeroRecibo.TextChanged += new System.EventHandler(this.TB_NumeroRecibo_TextChanged);
            // 
            // TB_MesInicio
            // 
            this.TB_MesInicio.Location = new System.Drawing.Point(167, 13);
            this.TB_MesInicio.Name = "TB_MesInicio";
            this.TB_MesInicio.Size = new System.Drawing.Size(148, 20);
            this.TB_MesInicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de recibo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mes de Inicio de Facturacion";
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 416);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 5;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_VerRecibo
            // 
            this.BTN_VerRecibo.Location = new System.Drawing.Point(703, 416);
            this.BTN_VerRecibo.Name = "BTN_VerRecibo";
            this.BTN_VerRecibo.Size = new System.Drawing.Size(75, 23);
            this.BTN_VerRecibo.TabIndex = 6;
            this.BTN_VerRecibo.Text = "Ver Recibo";
            this.BTN_VerRecibo.UseVisualStyleBackColor = true;
            this.BTN_VerRecibo.Click += new System.EventHandler(this.BTN_VerRecibo_Click);
            // 
            // DTG_AllRecibos
            // 
            this.DTG_AllRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_AllRecibos.Location = new System.Drawing.Point(13, 53);
            this.DTG_AllRecibos.Name = "DTG_AllRecibos";
            this.DTG_AllRecibos.Size = new System.Drawing.Size(765, 356);
            this.DTG_AllRecibos.TabIndex = 7;
            this.DTG_AllRecibos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_AllRecibos_CellContentClick);
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(321, 13);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Buscar.TabIndex = 8;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuario:";
            // 
            // LB_Usuario
            // 
            this.LB_Usuario.AutoSize = true;
            this.LB_Usuario.Location = new System.Drawing.Point(446, 22);
            this.LB_Usuario.Name = "LB_Usuario";
            this.LB_Usuario.Size = new System.Drawing.Size(35, 13);
            this.LB_Usuario.TabIndex = 10;
            this.LB_Usuario.Text = "label4";
            // 
            // BTN_Pagar
            // 
            this.BTN_Pagar.Location = new System.Drawing.Point(616, 415);
            this.BTN_Pagar.Name = "BTN_Pagar";
            this.BTN_Pagar.Size = new System.Drawing.Size(81, 23);
            this.BTN_Pagar.TabIndex = 11;
            this.BTN_Pagar.Text = "Pagar Recibo";
            this.BTN_Pagar.UseVisualStyleBackColor = true;
            this.BTN_Pagar.Click += new System.EventHandler(this.BTN_Pagar_Click);
            // 
            // MenuRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.BTN_Pagar);
            this.Controls.Add(this.LB_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.DTG_AllRecibos);
            this.Controls.Add(this.BTN_VerRecibo);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_MesInicio);
            this.Controls.Add(this.TB_NumeroRecibo);
            this.Name = "MenuRecibo";
            this.Text = "MenuRecibo";
            this.Load += new System.EventHandler(this.MenuRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_NumeroRecibo;
        private System.Windows.Forms.TextBox TB_MesInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_VerRecibo;
        private System.Windows.Forms.DataGridView DTG_AllRecibos;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_Usuario;
        private System.Windows.Forms.Button BTN_Pagar;
    }
}