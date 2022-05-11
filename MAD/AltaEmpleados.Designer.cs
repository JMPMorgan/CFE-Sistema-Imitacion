
namespace MAD
{
    partial class AltaEmpleados
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
            this.TB_RFC = new System.Windows.Forms.TextBox();
            this.TB_CURP = new System.Windows.Forms.TextBox();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.TB_Contraseña = new System.Windows.Forms.TextBox();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.BTN_Guradar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(13, 13);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(254, 20);
            this.TB_Nombre.TabIndex = 0;
            // 
            // TB_RFC
            // 
            this.TB_RFC.Location = new System.Drawing.Point(13, 55);
            this.TB_RFC.Name = "TB_RFC";
            this.TB_RFC.Size = new System.Drawing.Size(168, 20);
            this.TB_RFC.TabIndex = 1;
            // 
            // TB_CURP
            // 
            this.TB_CURP.Location = new System.Drawing.Point(13, 100);
            this.TB_CURP.Name = "TB_CURP";
            this.TB_CURP.Size = new System.Drawing.Size(168, 20);
            this.TB_CURP.TabIndex = 2;
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.Location = new System.Drawing.Point(318, 13);
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(169, 20);
            this.TB_Usuario.TabIndex = 3;
            // 
            // TB_Contraseña
            // 
            this.TB_Contraseña.Location = new System.Drawing.Point(318, 55);
            this.TB_Contraseña.Name = "TB_Contraseña";
            this.TB_Contraseña.Size = new System.Drawing.Size(169, 20);
            this.TB_Contraseña.TabIndex = 4;
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 166);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 5;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_Guradar
            // 
            this.BTN_Guradar.Location = new System.Drawing.Point(409, 166);
            this.BTN_Guradar.Name = "BTN_Guradar";
            this.BTN_Guradar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Guradar.TabIndex = 6;
            this.BTN_Guradar.Text = "Guardar";
            this.BTN_Guradar.UseVisualStyleBackColor = true;
            this.BTN_Guradar.Click += new System.EventHandler(this.BTN_Guradar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CURP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña";
            // 
            // DTP_Nacimiento
            // 
            this.DTP_Nacimiento.CustomFormat = "dd/MM/yyyy";
            this.DTP_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Nacimiento.Location = new System.Drawing.Point(318, 97);
            this.DTP_Nacimiento.Name = "DTP_Nacimiento";
            this.DTP_Nacimiento.Size = new System.Drawing.Size(169, 20);
            this.DTP_Nacimiento.TabIndex = 12;
            this.DTP_Nacimiento.Value = new System.DateTime(2021, 5, 3, 22, 49, 58, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // AltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 201);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTP_Nacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Guradar);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.TB_Contraseña);
            this.Controls.Add(this.TB_Usuario);
            this.Controls.Add(this.TB_CURP);
            this.Controls.Add(this.TB_RFC);
            this.Controls.Add(this.TB_Nombre);
            this.Name = "AltaEmpleados";
            this.Text = "AltaEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_RFC;
        private System.Windows.Forms.TextBox TB_CURP;
        private System.Windows.Forms.TextBox TB_Usuario;
        private System.Windows.Forms.TextBox TB_Contraseña;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_Guradar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_Nacimiento;
        private System.Windows.Forms.Label label6;
    }
}