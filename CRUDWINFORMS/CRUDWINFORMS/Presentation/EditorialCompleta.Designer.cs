namespace CRUDWINFORMS.Presentation
{
    partial class EditorialCompleta
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
            this.btnEditoriales = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnAlmacenes = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditoriales
            // 
            this.btnEditoriales.Location = new System.Drawing.Point(12, 12);
            this.btnEditoriales.Name = "btnEditoriales";
            this.btnEditoriales.Size = new System.Drawing.Size(75, 23);
            this.btnEditoriales.TabIndex = 0;
            this.btnEditoriales.Text = "Editoriales";
            this.btnEditoriales.UseVisualStyleBackColor = true;
            this.btnEditoriales.Click += new System.EventHandler(this.btnEditoriales_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Location = new System.Drawing.Point(93, 12);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(75, 23);
            this.btnAutores.TabIndex = 1;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnAlmacenes
            // 
            this.btnAlmacenes.Location = new System.Drawing.Point(12, 41);
            this.btnAlmacenes.Name = "btnAlmacenes";
            this.btnAlmacenes.Size = new System.Drawing.Size(75, 23);
            this.btnAlmacenes.TabIndex = 2;
            this.btnAlmacenes.Text = "Almacenes";
            this.btnAlmacenes.UseVisualStyleBackColor = true;
            // 
            // btnCargos
            // 
            this.btnCargos.Location = new System.Drawing.Point(93, 41);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(75, 23);
            this.btnCargos.TabIndex = 3;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.UseVisualStyleBackColor = true;
            // 
            // EditorialCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 83);
            this.Controls.Add(this.btnCargos);
            this.Controls.Add(this.btnAlmacenes);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.btnEditoriales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditorialCompleta";
            this.Text = "EditorialCompleta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditoriales;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnAlmacenes;
        private System.Windows.Forms.Button btnCargos;
    }
}