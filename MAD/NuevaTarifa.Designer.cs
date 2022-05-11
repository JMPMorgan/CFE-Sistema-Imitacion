
namespace MAD
{
    partial class NuevaTarifa
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
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Basica = new System.Windows.Forms.TextBox();
            this.TB_Intermedio = new System.Windows.Forms.TextBox();
            this.TB_Excedente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ST_Usuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(13, 314);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 0;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.Location = new System.Drawing.Point(234, 314);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Guardar.TabIndex = 1;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = true;
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(110, 12);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TB_Nombre.TabIndex = 2;
            // 
            // TB_Basica
            // 
            this.TB_Basica.Location = new System.Drawing.Point(110, 63);
            this.TB_Basica.Name = "TB_Basica";
            this.TB_Basica.Size = new System.Drawing.Size(100, 20);
            this.TB_Basica.TabIndex = 3;
            // 
            // TB_Intermedio
            // 
            this.TB_Intermedio.Location = new System.Drawing.Point(110, 112);
            this.TB_Intermedio.Name = "TB_Intermedio";
            this.TB_Intermedio.Size = new System.Drawing.Size(100, 20);
            this.TB_Intermedio.TabIndex = 4;
            // 
            // TB_Excedente
            // 
            this.TB_Excedente.Location = new System.Drawing.Point(110, 164);
            this.TB_Excedente.Name = "TB_Excedente";
            this.TB_Excedente.Size = new System.Drawing.Size(100, 20);
            this.TB_Excedente.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de la Tarifa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tarifa Basica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tarifa Intermedio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tarifa Excedente";
            // 
            // ST_Usuario
            // 
            this.ST_Usuario.AutoSize = true;
            this.ST_Usuario.Location = new System.Drawing.Point(55, 298);
            this.ST_Usuario.Name = "ST_Usuario";
            this.ST_Usuario.Size = new System.Drawing.Size(0, 13);
            this.ST_Usuario.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usuario:";
            // 
            // NuevaTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 349);
            this.Controls.Add(this.ST_Usuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Excedente);
            this.Controls.Add(this.TB_Intermedio);
            this.Controls.Add(this.TB_Basica);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.BTN_Regresar);
            this.Name = "NuevaTarifa";
            this.Text = "NuevaTarifa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Basica;
        private System.Windows.Forms.TextBox TB_Intermedio;
        private System.Windows.Forms.TextBox TB_Excedente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ST_Usuario;
        private System.Windows.Forms.Label label5;
    }
}