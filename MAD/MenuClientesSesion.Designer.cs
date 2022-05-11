
namespace MAD
{
    partial class MenuClientesSesion
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
            this.BTN_Consumo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 127);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 0;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_Consumo
            // 
            this.BTN_Consumo.Location = new System.Drawing.Point(131, 66);
            this.BTN_Consumo.Name = "BTN_Consumo";
            this.BTN_Consumo.Size = new System.Drawing.Size(134, 23);
            this.BTN_Consumo.TabIndex = 1;
            this.BTN_Consumo.Text = "Consumo Historico";
            this.BTN_Consumo.UseVisualStyleBackColor = true;
            this.BTN_Consumo.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuClientesSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 162);
            this.Controls.Add(this.BTN_Consumo);
            this.Controls.Add(this.BTN_Regresar);
            this.Name = "MenuClientesSesion";
            this.Text = "MenuClientesSesion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_Consumo;
    }
}