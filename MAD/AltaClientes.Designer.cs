
namespace MAD
{
    partial class AltaClientes
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
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_CURP = new System.Windows.Forms.TextBox();
            this.MC_Nacimiento = new System.Windows.Forms.MonthCalendar();
            this.GB_Sexo = new System.Windows.Forms.GroupBox();
            this.RB_Mujer = new System.Windows.Forms.RadioButton();
            this.RB_Hombre = new System.Windows.Forms.RadioButton();
            this.TB_NumCasa = new System.Windows.Forms.TextBox();
            this.TB_Calle = new System.Windows.Forms.TextBox();
            this.TB_Colonia = new System.Windows.Forms.TextBox();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ST_Usuario = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GB_Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(13, 13);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(225, 20);
            this.TB_Nombre.TabIndex = 0;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(13, 55);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(174, 20);
            this.TB_Email.TabIndex = 1;
            // 
            // TB_CURP
            // 
            this.TB_CURP.Location = new System.Drawing.Point(13, 96);
            this.TB_CURP.Name = "TB_CURP";
            this.TB_CURP.Size = new System.Drawing.Size(174, 20);
            this.TB_CURP.TabIndex = 2;
            // 
            // MC_Nacimiento
            // 
            this.MC_Nacimiento.Location = new System.Drawing.Point(320, 13);
            this.MC_Nacimiento.Name = "MC_Nacimiento";
            this.MC_Nacimiento.TabIndex = 3;
            // 
            // GB_Sexo
            // 
            this.GB_Sexo.Controls.Add(this.RB_Mujer);
            this.GB_Sexo.Controls.Add(this.RB_Hombre);
            this.GB_Sexo.Location = new System.Drawing.Point(320, 188);
            this.GB_Sexo.Name = "GB_Sexo";
            this.GB_Sexo.Size = new System.Drawing.Size(200, 74);
            this.GB_Sexo.TabIndex = 4;
            this.GB_Sexo.TabStop = false;
            this.GB_Sexo.Text = "groupBox1";
            // 
            // RB_Mujer
            // 
            this.RB_Mujer.AutoSize = true;
            this.RB_Mujer.Location = new System.Drawing.Point(7, 43);
            this.RB_Mujer.Name = "RB_Mujer";
            this.RB_Mujer.Size = new System.Drawing.Size(51, 17);
            this.RB_Mujer.TabIndex = 1;
            this.RB_Mujer.TabStop = true;
            this.RB_Mujer.Text = "Mujer";
            this.RB_Mujer.UseVisualStyleBackColor = true;
            // 
            // RB_Hombre
            // 
            this.RB_Hombre.AutoSize = true;
            this.RB_Hombre.Location = new System.Drawing.Point(7, 20);
            this.RB_Hombre.Name = "RB_Hombre";
            this.RB_Hombre.Size = new System.Drawing.Size(62, 17);
            this.RB_Hombre.TabIndex = 0;
            this.RB_Hombre.TabStop = true;
            this.RB_Hombre.Text = "Hombre";
            this.RB_Hombre.UseVisualStyleBackColor = true;
            // 
            // TB_NumCasa
            // 
            this.TB_NumCasa.Location = new System.Drawing.Point(320, 360);
            this.TB_NumCasa.Name = "TB_NumCasa";
            this.TB_NumCasa.Size = new System.Drawing.Size(200, 20);
            this.TB_NumCasa.TabIndex = 7;
            // 
            // TB_Calle
            // 
            this.TB_Calle.Location = new System.Drawing.Point(320, 319);
            this.TB_Calle.Name = "TB_Calle";
            this.TB_Calle.Size = new System.Drawing.Size(200, 20);
            this.TB_Calle.TabIndex = 6;
            // 
            // TB_Colonia
            // 
            this.TB_Colonia.Location = new System.Drawing.Point(320, 277);
            this.TB_Colonia.Name = "TB_Colonia";
            this.TB_Colonia.Size = new System.Drawing.Size(200, 20);
            this.TB_Colonia.TabIndex = 5;
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(13, 408);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 8;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.Location = new System.Drawing.Point(484, 408);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Guardar.TabIndex = 9;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = true;
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "CURP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Colonia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Calle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Numero de Casa";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(12, 135);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(174, 20);
            this.TB_Password.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contraseña";
            // 
            // ST_Usuario
            // 
            this.ST_Usuario.AutoSize = true;
            this.ST_Usuario.Location = new System.Drawing.Point(59, 383);
            this.ST_Usuario.Name = "ST_Usuario";
            this.ST_Usuario.Size = new System.Drawing.Size(0, 13);
            this.ST_Usuario.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Usuario:";
            // 
            // AltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 443);
            this.Controls.Add(this.ST_Usuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.TB_NumCasa);
            this.Controls.Add(this.TB_Calle);
            this.Controls.Add(this.TB_Colonia);
            this.Controls.Add(this.GB_Sexo);
            this.Controls.Add(this.MC_Nacimiento);
            this.Controls.Add(this.TB_CURP);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.TB_Nombre);
            this.Name = "AltaClientes";
            this.Text = "AltaClientes";
            this.GB_Sexo.ResumeLayout(false);
            this.GB_Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_CURP;
        private System.Windows.Forms.MonthCalendar MC_Nacimiento;
        private System.Windows.Forms.GroupBox GB_Sexo;
        private System.Windows.Forms.RadioButton RB_Mujer;
        private System.Windows.Forms.RadioButton RB_Hombre;
        private System.Windows.Forms.TextBox TB_NumCasa;
        private System.Windows.Forms.TextBox TB_Calle;
        private System.Windows.Forms.TextBox TB_Colonia;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ST_Usuario;
        private System.Windows.Forms.Label label8;
    }
}