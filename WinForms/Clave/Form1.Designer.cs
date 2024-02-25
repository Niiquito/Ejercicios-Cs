namespace Clave
{
    partial class Form1
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
            this.lbl_clave = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_verify = new System.Windows.Forms.Button();
            this.txtbox_clave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.Location = new System.Drawing.Point(34, 116);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(37, 13);
            this.lbl_clave.TabIndex = 0;
            this.lbl_clave.Text = "Clave:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.Color.White;
            this.lbl_resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_resultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(86, 181);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(101, 33);
            this.lbl_resultado.TabIndex = 1;
            this.lbl_resultado.Text = "Estado";
            // 
            // btn_verify
            // 
            this.btn_verify.Location = new System.Drawing.Point(99, 139);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(75, 23);
            this.btn_verify.TabIndex = 2;
            this.btn_verify.Text = "Verificar";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // txtbox_clave
            // 
            this.txtbox_clave.Location = new System.Drawing.Point(87, 113);
            this.txtbox_clave.Name = "txtbox_clave";
            this.txtbox_clave.Size = new System.Drawing.Size(100, 20);
            this.txtbox_clave.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.txtbox_clave);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_clave);
            this.Name = "Form1";
            this.Text = "Clave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.TextBox txtbox_clave;
    }
}

