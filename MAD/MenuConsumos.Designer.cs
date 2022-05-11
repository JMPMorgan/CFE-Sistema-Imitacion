
namespace MAD
{
    partial class MenuConsumos
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
            this.TB_Buscar = new System.Windows.Forms.TextBox();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DTG_AllContratosCliente = new System.Windows.Forms.DataGridView();
            this.LB_Usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllContratosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Buscar
            // 
            this.TB_Buscar.Location = new System.Drawing.Point(13, 13);
            this.TB_Buscar.Name = "TB_Buscar";
            this.TB_Buscar.Size = new System.Drawing.Size(100, 20);
            this.TB_Buscar.TabIndex = 0;
            this.TB_Buscar.TextChanged += new System.EventHandler(this.TB_Buscar_TextChanged);
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(13, 455);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 2;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(511, 455);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(105, 23);
            this.BTN_Agregar.TabIndex = 3;
            this.BTN_Agregar.Text = "Agregar Consumo";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Cliente";
            // 
            // DTG_AllContratosCliente
            // 
            this.DTG_AllContratosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_AllContratosCliente.Location = new System.Drawing.Point(13, 53);
            this.DTG_AllContratosCliente.Name = "DTG_AllContratosCliente";
            this.DTG_AllContratosCliente.Size = new System.Drawing.Size(603, 396);
            this.DTG_AllContratosCliente.TabIndex = 5;
            this.DTG_AllContratosCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_AllContratosCliente_CellContentClick);
            // 
            // LB_Usuario
            // 
            this.LB_Usuario.AutoSize = true;
            this.LB_Usuario.Location = new System.Drawing.Point(580, 37);
            this.LB_Usuario.Name = "LB_Usuario";
            this.LB_Usuario.Size = new System.Drawing.Size(35, 13);
            this.LB_Usuario.TabIndex = 12;
            this.LB_Usuario.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Usuario:";
            // 
            // MenuConsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 486);
            this.Controls.Add(this.LB_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTG_AllContratosCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.TB_Buscar);
            this.Name = "MenuConsumos";
            this.Text = "MenuConsumos";
            this.Load += new System.EventHandler(this.MenuConsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllContratosCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Buscar;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DTG_AllContratosCliente;
        private System.Windows.Forms.Label LB_Usuario;
        private System.Windows.Forms.Label label3;
    }
}