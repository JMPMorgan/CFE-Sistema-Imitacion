
namespace MAD
{
    partial class MostrarContratos
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
            this.DTG_AllContratos = new System.Windows.Forms.DataGridView();
            this.ST_Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 446);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 0;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // DTG_AllContratos
            // 
            this.DTG_AllContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_AllContratos.Location = new System.Drawing.Point(13, 12);
            this.DTG_AllContratos.Name = "DTG_AllContratos";
            this.DTG_AllContratos.Size = new System.Drawing.Size(885, 428);
            this.DTG_AllContratos.TabIndex = 1;
            this.DTG_AllContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_AllContratos_CellContentClick);
            // 
            // ST_Usuario
            // 
            this.ST_Usuario.AutoSize = true;
            this.ST_Usuario.Location = new System.Drawing.Point(139, 451);
            this.ST_Usuario.Name = "ST_Usuario";
            this.ST_Usuario.Size = new System.Drawing.Size(0, 13);
            this.ST_Usuario.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Usuario:";
            // 
            // MostrarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 481);
            this.Controls.Add(this.ST_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTG_AllContratos);
            this.Controls.Add(this.BTN_Regresar);
            this.Name = "MostrarContratos";
            this.Text = "MostrarContratos";
            this.Load += new System.EventHandler(this.MostrarContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.DataGridView DTG_AllContratos;
        private System.Windows.Forms.Label ST_Usuario;
        private System.Windows.Forms.Label label2;
    }
}