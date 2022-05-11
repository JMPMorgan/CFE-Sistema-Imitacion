
namespace MAD
{
    partial class MenuClientes
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
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.DTG_AllClientes = new System.Windows.Forms.DataGridView();
            this.ST_Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.Location = new System.Drawing.Point(12, 12);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(103, 23);
            this.BTN_Registrar.TabIndex = 0;
            this.BTN_Registrar.Text = "Registrar Cliente";
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.Location = new System.Drawing.Point(12, 50);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(103, 23);
            this.BTN_Modificar.TabIndex = 1;
            this.BTN_Modificar.Text = "Modificar Cliente";
            this.BTN_Modificar.UseVisualStyleBackColor = true;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.Location = new System.Drawing.Point(12, 91);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(103, 23);
            this.BTN_Eliminar.TabIndex = 2;
            this.BTN_Eliminar.Text = "Eliminar Cliente";
            this.BTN_Eliminar.UseVisualStyleBackColor = true;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 398);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(103, 23);
            this.BTN_Regresar.TabIndex = 4;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // DTG_AllClientes
            // 
            this.DTG_AllClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_AllClientes.Location = new System.Drawing.Point(121, 33);
            this.DTG_AllClientes.Name = "DTG_AllClientes";
            this.DTG_AllClientes.Size = new System.Drawing.Size(576, 394);
            this.DTG_AllClientes.TabIndex = 5;
            this.DTG_AllClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_AllClientes_CellContentClick);
            // 
            // ST_Usuario
            // 
            this.ST_Usuario.AutoSize = true;
            this.ST_Usuario.Location = new System.Drawing.Point(189, 17);
            this.ST_Usuario.Name = "ST_Usuario";
            this.ST_Usuario.Size = new System.Drawing.Size(0, 13);
            this.ST_Usuario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 433);
            this.Controls.Add(this.ST_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTG_AllClientes);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.BTN_Registrar);
            this.Name = "MenuClientes";
            this.Text = "MenuClientes";
            this.Load += new System.EventHandler(this.MenuClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.DataGridView DTG_AllClientes;
        private System.Windows.Forms.Label ST_Usuario;
        private System.Windows.Forms.Label label2;
    }
}