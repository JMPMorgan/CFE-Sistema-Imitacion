
namespace MAD
{
    partial class MenuReportes
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
            this.BTN_General = new System.Windows.Forms.Button();
            this.BTN_Tarifas = new System.Windows.Forms.Button();
            this.BTN_Consumo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LT_Usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(13, 293);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 0;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_General
            // 
            this.BTN_General.Location = new System.Drawing.Point(71, 12);
            this.BTN_General.Name = "BTN_General";
            this.BTN_General.Size = new System.Drawing.Size(109, 23);
            this.BTN_General.TabIndex = 1;
            this.BTN_General.Text = "Reporte General";
            this.BTN_General.UseVisualStyleBackColor = true;
            this.BTN_General.Click += new System.EventHandler(this.BTN_General_Click);
            // 
            // BTN_Tarifas
            // 
            this.BTN_Tarifas.Location = new System.Drawing.Point(71, 61);
            this.BTN_Tarifas.Name = "BTN_Tarifas";
            this.BTN_Tarifas.Size = new System.Drawing.Size(109, 23);
            this.BTN_Tarifas.TabIndex = 2;
            this.BTN_Tarifas.Text = "Reporte Tarifas";
            this.BTN_Tarifas.UseVisualStyleBackColor = true;
            this.BTN_Tarifas.Click += new System.EventHandler(this.BTN_Tarifas_Click);
            // 
            // BTN_Consumo
            // 
            this.BTN_Consumo.Location = new System.Drawing.Point(71, 110);
            this.BTN_Consumo.Name = "BTN_Consumo";
            this.BTN_Consumo.Size = new System.Drawing.Size(109, 23);
            this.BTN_Consumo.TabIndex = 3;
            this.BTN_Consumo.Text = "Reporte Consumo";
            this.BTN_Consumo.UseVisualStyleBackColor = true;
            this.BTN_Consumo.Click += new System.EventHandler(this.BTN_Consumo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // LT_Usuario
            // 
            this.LT_Usuario.AutoSize = true;
            this.LT_Usuario.Location = new System.Drawing.Point(55, 274);
            this.LT_Usuario.Name = "LT_Usuario";
            this.LT_Usuario.Size = new System.Drawing.Size(71, 13);
            this.LT_Usuario.TabIndex = 5;
            this.LT_Usuario.Text = "usuarioActual";
            // 
            // MenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 328);
            this.Controls.Add(this.LT_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Consumo);
            this.Controls.Add(this.BTN_Tarifas);
            this.Controls.Add(this.BTN_General);
            this.Controls.Add(this.BTN_Regresar);
            this.Name = "MenuReportes";
            this.Text = "MenuReportes";
            this.Load += new System.EventHandler(this.MenuReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_General;
        private System.Windows.Forms.Button BTN_Tarifas;
        private System.Windows.Forms.Button BTN_Consumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LT_Usuario;
    }
}