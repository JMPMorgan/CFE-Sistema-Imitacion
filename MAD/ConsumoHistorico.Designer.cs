
namespace MAD
{
    partial class ConsumoHistorico
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
            this.TB_Ano = new System.Windows.Forms.TextBox();
            this.TB_medidor = new System.Windows.Forms.TextBox();
            this.TB_servicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_PDF = new System.Windows.Forms.Button();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Ano
            // 
            this.TB_Ano.Location = new System.Drawing.Point(13, 13);
            this.TB_Ano.Name = "TB_Ano";
            this.TB_Ano.Size = new System.Drawing.Size(139, 20);
            this.TB_Ano.TabIndex = 0;
            // 
            // TB_medidor
            // 
            this.TB_medidor.Location = new System.Drawing.Point(13, 56);
            this.TB_medidor.Name = "TB_medidor";
            this.TB_medidor.Size = new System.Drawing.Size(139, 20);
            this.TB_medidor.TabIndex = 1;
            // 
            // TB_servicio
            // 
            this.TB_servicio.Location = new System.Drawing.Point(13, 101);
            this.TB_servicio.Name = "TB_servicio";
            this.TB_servicio.Size = new System.Drawing.Size(139, 20);
            this.TB_servicio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese el medidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese Numero Servicio";
            // 
            // BTN_PDF
            // 
            this.BTN_PDF.Location = new System.Drawing.Point(386, 13);
            this.BTN_PDF.Name = "BTN_PDF";
            this.BTN_PDF.Size = new System.Drawing.Size(75, 23);
            this.BTN_PDF.TabIndex = 6;
            this.BTN_PDF.Text = "Crear PDF";
            this.BTN_PDF.UseVisualStyleBackColor = true;
            this.BTN_PDF.Click += new System.EventHandler(this.BTN_PDF_Click);
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(386, 101);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 7;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // ConsumoHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 155);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.BTN_PDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_servicio);
            this.Controls.Add(this.TB_medidor);
            this.Controls.Add(this.TB_Ano);
            this.Name = "ConsumoHistorico";
            this.Text = "ConsumoHistorico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Ano;
        private System.Windows.Forms.TextBox TB_medidor;
        private System.Windows.Forms.TextBox TB_servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_PDF;
        private System.Windows.Forms.Button BTN_Regresar;
    }
}