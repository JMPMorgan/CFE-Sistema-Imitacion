
namespace MAD
{
    partial class MenuAltaEmpleados
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
            this.BTN_Alta = new System.Windows.Forms.Button();
            this.BTN_Editar = new System.Windows.Forms.Button();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.DTG_AllEmpleados = new System.Windows.Forms.DataGridView();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Alta
            // 
            this.BTN_Alta.Location = new System.Drawing.Point(13, 13);
            this.BTN_Alta.Name = "BTN_Alta";
            this.BTN_Alta.Size = new System.Drawing.Size(101, 23);
            this.BTN_Alta.TabIndex = 0;
            this.BTN_Alta.Text = "Alta Empleado";
            this.BTN_Alta.UseVisualStyleBackColor = true;
            this.BTN_Alta.Click += new System.EventHandler(this.BTN_Alta_Click);
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.Location = new System.Drawing.Point(13, 42);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Size = new System.Drawing.Size(101, 23);
            this.BTN_Editar.TabIndex = 1;
            this.BTN_Editar.Text = "Editar Empleado";
            this.BTN_Editar.UseVisualStyleBackColor = true;
            this.BTN_Editar.Click += new System.EventHandler(this.BTN_Editar_Click);
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.Location = new System.Drawing.Point(13, 71);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(101, 23);
            this.BTN_Eliminar.TabIndex = 2;
            this.BTN_Eliminar.Text = "Borrar Empleado";
            this.BTN_Eliminar.UseVisualStyleBackColor = true;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // DTG_AllEmpleados
            // 
            this.DTG_AllEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_AllEmpleados.Location = new System.Drawing.Point(138, 13);
            this.DTG_AllEmpleados.Name = "DTG_AllEmpleados";
            this.DTG_AllEmpleados.Size = new System.Drawing.Size(650, 425);
            this.DTG_AllEmpleados.TabIndex = 3;
            this.DTG_AllEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_AllEmpleados_CellContentClick);
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Location = new System.Drawing.Point(13, 415);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Regresar.TabIndex = 4;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // MenuAltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.DTG_AllEmpleados);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.BTN_Alta);
            this.Name = "MenuAltaEmpleados";
            this.Text = "MenuAltaEmpleados";
            this.Load += new System.EventHandler(this.MenuAltaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_AllEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Alta;
        private System.Windows.Forms.Button BTN_Editar;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.DataGridView DTG_AllEmpleados;
        private System.Windows.Forms.Button BTN_Regresar;
    }
}