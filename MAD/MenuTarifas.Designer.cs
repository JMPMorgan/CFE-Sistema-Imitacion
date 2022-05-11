
namespace MAD
{
    partial class MenuTarifas
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
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.DTG_AllTarifas = new System.Windows.Forms.DataGridView();
            this.ST_Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(13, 13);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(99, 23);
            this.BTN_Agregar.TabIndex = 0;
            this.BTN_Agregar.Text = "Agregar Tarifa";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.Location = new System.Drawing.Point(12, 42);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(99, 23);
            this.BTN_Eliminar.TabIndex = 1;
            this.BTN_Eliminar.Text = "EliminarTarifa";
            this.BTN_Eliminar.UseVisualStyleBackColor = true;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 288);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 3;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // DTG_AllTarifas
            // 
            this.DTG_AllTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_AllTarifas.Location = new System.Drawing.Point(119, 13);
            this.DTG_AllTarifas.Name = "DTG_AllTarifas";
            this.DTG_AllTarifas.Size = new System.Drawing.Size(379, 298);
            this.DTG_AllTarifas.TabIndex = 4;
            this.DTG_AllTarifas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_AllTarifas_CellContentClick);
            // 
            // ST_Usuario
            // 
            this.ST_Usuario.AutoSize = true;
            this.ST_Usuario.Location = new System.Drawing.Point(53, 272);
            this.ST_Usuario.Name = "ST_Usuario";
            this.ST_Usuario.Size = new System.Drawing.Size(0, 13);
            this.ST_Usuario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // MenuTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 323);
            this.Controls.Add(this.ST_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTG_AllTarifas);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Agregar);
            this.Name = "MenuTarifas";
            this.Text = "MenuTarifas";
            this.Load += new System.EventHandler(this.MenuTarifas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllTarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.DataGridView DTG_AllTarifas;
        private System.Windows.Forms.Label ST_Usuario;
        private System.Windows.Forms.Label label1;
    }
}