
namespace MAD
{
    partial class EditarEmpleado
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
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Guradar = new System.Windows.Forms.Button();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.TB_Contraseña = new System.Windows.Forms.TextBox();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_RFC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // DTP_Nacimiento
            // 
            this.DTP_Nacimiento.CustomFormat = "dd/MM/yyyy";
            this.DTP_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Nacimiento.Location = new System.Drawing.Point(333, 54);
            this.DTP_Nacimiento.Name = "DTP_Nacimiento";
            this.DTP_Nacimiento.Size = new System.Drawing.Size(169, 20);
            this.DTP_Nacimiento.TabIndex = 26;
            this.DTP_Nacimiento.Value = new System.DateTime(2021, 5, 3, 22, 49, 58, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre del Empleado";
            // 
            // BTN_Guradar
            // 
            this.BTN_Guradar.Location = new System.Drawing.Point(427, 109);
            this.BTN_Guradar.Name = "BTN_Guradar";
            this.BTN_Guradar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Guradar.TabIndex = 20;
            this.BTN_Guradar.Text = "Guardar";
            this.BTN_Guradar.UseVisualStyleBackColor = true;
            this.BTN_Guradar.Click += new System.EventHandler(this.BTN_Guradar_Click);
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 109);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 19;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            // 
            // TB_Contraseña
            // 
            this.TB_Contraseña.Location = new System.Drawing.Point(333, 12);
            this.TB_Contraseña.Name = "TB_Contraseña";
            this.TB_Contraseña.Size = new System.Drawing.Size(169, 20);
            this.TB_Contraseña.TabIndex = 18;
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(12, 12);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(254, 20);
            this.TB_Nombre.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "RFC";
            // 
            // TB_RFC
            // 
            this.TB_RFC.Location = new System.Drawing.Point(15, 51);
            this.TB_RFC.Name = "TB_RFC";
            this.TB_RFC.Size = new System.Drawing.Size(168, 20);
            this.TB_RFC.TabIndex = 15;
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 148);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTP_Nacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Guradar);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.TB_Contraseña);
            this.Controls.Add(this.TB_RFC);
            this.Controls.Add(this.TB_Nombre);
            this.Name = "EditarEmpleado";
            this.Text = "EditarEmpleado";
            this.Load += new System.EventHandler(this.EditarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTP_Nacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Guradar;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.TextBox TB_Contraseña;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_RFC;
    }
}