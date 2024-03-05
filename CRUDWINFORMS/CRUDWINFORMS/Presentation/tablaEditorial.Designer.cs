namespace CRUDWINFORMS.Presentation
{
    partial class tablaEditorial
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(57, 9);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(61, 35);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 8;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(61, 58);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 11;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(74, 87);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(27, 13);
            this.lbl_pais.TabIndex = 12;
            this.lbl_pais.Text = "Pais";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(107, 84);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 13;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(107, 58);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 14;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(107, 32);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(132, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tablaEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 193);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_ciudad);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tablaEditorial";
            this.Text = "Editorial";
            this.Load += new System.EventHandler(this.tablaEditorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnGuardar;
    }
}