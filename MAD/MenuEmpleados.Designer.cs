
namespace MAD
{
    partial class MenuEmpleados
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
            this.BTN_Clientes = new System.Windows.Forms.Button();
            this.BTN_Contratos = new System.Windows.Forms.Button();
            this.Tarifas = new System.Windows.Forms.Button();
            this.BTN_Consumos = new System.Windows.Forms.Button();
            this.BTN_Recibos = new System.Windows.Forms.Button();
            this.BTN_Reportes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ST_Usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Clientes
            // 
            this.BTN_Clientes.Location = new System.Drawing.Point(85, 62);
            this.BTN_Clientes.Name = "BTN_Clientes";
            this.BTN_Clientes.Size = new System.Drawing.Size(75, 23);
            this.BTN_Clientes.TabIndex = 0;
            this.BTN_Clientes.Text = "Clientes";
            this.BTN_Clientes.UseVisualStyleBackColor = true;
            this.BTN_Clientes.Click += new System.EventHandler(this.BTN_Clientes_Click);
            // 
            // BTN_Contratos
            // 
            this.BTN_Contratos.Location = new System.Drawing.Point(85, 101);
            this.BTN_Contratos.Name = "BTN_Contratos";
            this.BTN_Contratos.Size = new System.Drawing.Size(75, 23);
            this.BTN_Contratos.TabIndex = 1;
            this.BTN_Contratos.Text = "Contratos";
            this.BTN_Contratos.UseVisualStyleBackColor = true;
            this.BTN_Contratos.Click += new System.EventHandler(this.BTN_Contratos_Click);
            // 
            // Tarifas
            // 
            this.Tarifas.Location = new System.Drawing.Point(85, 140);
            this.Tarifas.Name = "Tarifas";
            this.Tarifas.Size = new System.Drawing.Size(75, 23);
            this.Tarifas.TabIndex = 2;
            this.Tarifas.Text = "Tarifas";
            this.Tarifas.UseVisualStyleBackColor = true;
            this.Tarifas.Click += new System.EventHandler(this.Tarifas_Click);
            // 
            // BTN_Consumos
            // 
            this.BTN_Consumos.Location = new System.Drawing.Point(85, 179);
            this.BTN_Consumos.Name = "BTN_Consumos";
            this.BTN_Consumos.Size = new System.Drawing.Size(75, 23);
            this.BTN_Consumos.TabIndex = 3;
            this.BTN_Consumos.Text = "Consumos";
            this.BTN_Consumos.UseVisualStyleBackColor = true;
            this.BTN_Consumos.Click += new System.EventHandler(this.BTN_Consumos_Click);
            // 
            // BTN_Recibos
            // 
            this.BTN_Recibos.Location = new System.Drawing.Point(85, 218);
            this.BTN_Recibos.Name = "BTN_Recibos";
            this.BTN_Recibos.Size = new System.Drawing.Size(75, 23);
            this.BTN_Recibos.TabIndex = 4;
            this.BTN_Recibos.Text = "Recibos";
            this.BTN_Recibos.UseVisualStyleBackColor = true;
            this.BTN_Recibos.Click += new System.EventHandler(this.BTN_Recibos_Click);
            // 
            // BTN_Reportes
            // 
            this.BTN_Reportes.Location = new System.Drawing.Point(85, 257);
            this.BTN_Reportes.Name = "BTN_Reportes";
            this.BTN_Reportes.Size = new System.Drawing.Size(75, 23);
            this.BTN_Reportes.TabIndex = 5;
            this.BTN_Reportes.Text = "Reportes";
            this.BTN_Reportes.UseVisualStyleBackColor = true;
            this.BTN_Reportes.Click += new System.EventHandler(this.BTN_Reportes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // ST_Usuario
            // 
            this.ST_Usuario.AutoSize = true;
            this.ST_Usuario.Location = new System.Drawing.Point(56, 321);
            this.ST_Usuario.Name = "ST_Usuario";
            this.ST_Usuario.Size = new System.Drawing.Size(0, 13);
            this.ST_Usuario.TabIndex = 7;
            // 
            // MenuEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 346);
            this.Controls.Add(this.ST_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Reportes);
            this.Controls.Add(this.BTN_Recibos);
            this.Controls.Add(this.BTN_Consumos);
            this.Controls.Add(this.Tarifas);
            this.Controls.Add(this.BTN_Contratos);
            this.Controls.Add(this.BTN_Clientes);
            this.Name = "MenuEmpleados";
            this.Text = "MenuEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Clientes;
        private System.Windows.Forms.Button BTN_Contratos;
        private System.Windows.Forms.Button Tarifas;
        private System.Windows.Forms.Button BTN_Consumos;
        private System.Windows.Forms.Button BTN_Recibos;
        private System.Windows.Forms.Button BTN_Reportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ST_Usuario;
    }
}