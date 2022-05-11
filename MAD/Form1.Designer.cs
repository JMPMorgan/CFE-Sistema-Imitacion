
namespace MAD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Location = new System.Drawing.Point(85, 297);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(75, 23);
            this.BTN_Salir.TabIndex = 0;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = true;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.Location = new System.Drawing.Point(73, 104);
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(100, 20);
            this.TB_Usuario.TabIndex = 1;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(73, 148);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(100, 20);
            this.TB_Password.TabIndex = 2;
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.Location = new System.Drawing.Point(85, 257);
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Entrar.TabIndex = 3;
            this.BTN_Entrar.Text = "Entrar";
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.BTN_Entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Entrar);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Usuario);
            this.Controls.Add(this.BTN_Salir);
            this.Name = "Form1";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.TextBox TB_Usuario;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

