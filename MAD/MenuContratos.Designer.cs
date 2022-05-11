
namespace MAD
{
    partial class MenuContratos
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
            this.BTN_AgregarContrato = new System.Windows.Forms.Button();
            this.BTN_MostrarContratos = new System.Windows.Forms.Button();
            this.TB_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.DTG_AllClientes = new System.Windows.Forms.DataGridView();
            this.ST_Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_AgregarContrato
            // 
            this.BTN_AgregarContrato.Location = new System.Drawing.Point(13, 13);
            this.BTN_AgregarContrato.Name = "BTN_AgregarContrato";
            this.BTN_AgregarContrato.Size = new System.Drawing.Size(107, 23);
            this.BTN_AgregarContrato.TabIndex = 0;
            this.BTN_AgregarContrato.Text = "Añadir Contrato";
            this.BTN_AgregarContrato.UseVisualStyleBackColor = true;
            this.BTN_AgregarContrato.Click += new System.EventHandler(this.BTN_AgregarContrato_Click);
            // 
            // BTN_MostrarContratos
            // 
            this.BTN_MostrarContratos.Location = new System.Drawing.Point(12, 51);
            this.BTN_MostrarContratos.Name = "BTN_MostrarContratos";
            this.BTN_MostrarContratos.Size = new System.Drawing.Size(108, 23);
            this.BTN_MostrarContratos.TabIndex = 1;
            this.BTN_MostrarContratos.Text = "Mostrar Contratos";
            this.BTN_MostrarContratos.UseVisualStyleBackColor = true;
            this.BTN_MostrarContratos.Click += new System.EventHandler(this.BTN_MostrarContratos_Click);
            // 
            // TB_Buscar
            // 
            this.TB_Buscar.Location = new System.Drawing.Point(169, 13);
            this.TB_Buscar.Name = "TB_Buscar";
            this.TB_Buscar.Size = new System.Drawing.Size(153, 20);
            this.TB_Buscar.TabIndex = 3;
            this.TB_Buscar.TextChanged += new System.EventHandler(this.TB_Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Cliente";
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(13, 415);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 5;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // DTG_AllClientes
            // 
            this.DTG_AllClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_AllClientes.Location = new System.Drawing.Point(169, 52);
            this.DTG_AllClientes.Name = "DTG_AllClientes";
            this.DTG_AllClientes.Size = new System.Drawing.Size(627, 386);
            this.DTG_AllClientes.TabIndex = 6;
            this.DTG_AllClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_AllClientes_CellContentClick);
            // 
            // ST_Usuario
            // 
            this.ST_Usuario.AutoSize = true;
            this.ST_Usuario.Location = new System.Drawing.Point(579, 23);
            this.ST_Usuario.Name = "ST_Usuario";
            this.ST_Usuario.Size = new System.Drawing.Size(0, 13);
            this.ST_Usuario.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario:";
            // 
            // MenuContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.ST_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTG_AllClientes);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Buscar);
            this.Controls.Add(this.BTN_MostrarContratos);
            this.Controls.Add(this.BTN_AgregarContrato);
            this.Name = "MenuContratos";
            this.Text = "MenuContratos";
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_AgregarContrato;
        private System.Windows.Forms.Button BTN_MostrarContratos;
        private System.Windows.Forms.TextBox TB_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.DataGridView DTG_AllClientes;
        private System.Windows.Forms.Label ST_Usuario;
        private System.Windows.Forms.Label label2;
    }
}