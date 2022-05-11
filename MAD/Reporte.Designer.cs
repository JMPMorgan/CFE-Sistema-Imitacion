
namespace MAD
{
    partial class Reporte
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
            this.TB_Año = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.BTN_PDF = new System.Windows.Forms.Button();
            this.LT_Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Año
            // 
            this.TB_Año.Location = new System.Drawing.Point(13, 13);
            this.TB_Año.Name = "TB_Año";
            this.TB_Año.Size = new System.Drawing.Size(100, 20);
            this.TB_Año.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el año de busqueda";
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 164);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 3;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_PDF
            // 
            this.BTN_PDF.Location = new System.Drawing.Point(189, 164);
            this.BTN_PDF.Name = "BTN_PDF";
            this.BTN_PDF.Size = new System.Drawing.Size(75, 23);
            this.BTN_PDF.TabIndex = 4;
            this.BTN_PDF.Text = "Crear PDF";
            this.BTN_PDF.UseVisualStyleBackColor = true;
            this.BTN_PDF.Click += new System.EventHandler(this.BTN_PDF_Click);
            // 
            // LT_Usuario
            // 
            this.LT_Usuario.AutoSize = true;
            this.LT_Usuario.Location = new System.Drawing.Point(161, 20);
            this.LT_Usuario.Name = "LT_Usuario";
            this.LT_Usuario.Size = new System.Drawing.Size(71, 13);
            this.LT_Usuario.TabIndex = 7;
            this.LT_Usuario.Text = "usuarioActual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario:";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 199);
            this.Controls.Add(this.LT_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_PDF);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Año);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Año;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_PDF;
        private System.Windows.Forms.Label LT_Usuario;
        private System.Windows.Forms.Label label2;
    }
}