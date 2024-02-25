namespace Prueba
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
            this.btn_suma = new System.Windows.Forms.Button();
            this.lbl_primerValor = new System.Windows.Forms.Label();
            this.lbl_segundoValor = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txtbox_primerValor = new System.Windows.Forms.TextBox();
            this.txtbox_segundoValor = new System.Windows.Forms.TextBox();
            this.btn_resta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(102, 113);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(75, 23);
            this.btn_suma.TabIndex = 0;
            this.btn_suma.Text = "Sumar";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // lbl_primerValor
            // 
            this.lbl_primerValor.AutoSize = true;
            this.lbl_primerValor.Location = new System.Drawing.Point(31, 19);
            this.lbl_primerValor.Name = "lbl_primerValor";
            this.lbl_primerValor.Size = new System.Drawing.Size(102, 13);
            this.lbl_primerValor.TabIndex = 1;
            this.lbl_primerValor.Text = "Ingrese primer valor:";
            // 
            // lbl_segundoValor
            // 
            this.lbl_segundoValor.AutoSize = true;
            this.lbl_segundoValor.Location = new System.Drawing.Point(31, 60);
            this.lbl_segundoValor.Name = "lbl_segundoValor";
            this.lbl_segundoValor.Size = new System.Drawing.Size(115, 13);
            this.lbl_segundoValor.TabIndex = 2;
            this.lbl_segundoValor.Text = "Ingrese segundo valor:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(146, 92);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_resultado.TabIndex = 3;
            // 
            // txtbox_primerValor
            // 
            this.txtbox_primerValor.Location = new System.Drawing.Point(148, 19);
            this.txtbox_primerValor.Name = "txtbox_primerValor";
            this.txtbox_primerValor.Size = new System.Drawing.Size(100, 20);
            this.txtbox_primerValor.TabIndex = 4;
            // 
            // txtbox_segundoValor
            // 
            this.txtbox_segundoValor.Location = new System.Drawing.Point(148, 57);
            this.txtbox_segundoValor.Name = "txtbox_segundoValor";
            this.txtbox_segundoValor.Size = new System.Drawing.Size(100, 20);
            this.txtbox_segundoValor.TabIndex = 5;
            // 
            // btn_resta
            // 
            this.btn_resta.Location = new System.Drawing.Point(183, 113);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(75, 23);
            this.btn_resta.TabIndex = 6;
            this.btn_resta.Text = "Restar";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.txtbox_segundoValor);
            this.Controls.Add(this.txtbox_primerValor);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_segundoValor);
            this.Controls.Add(this.lbl_primerValor);
            this.Controls.Add(this.btn_suma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Label lbl_primerValor;
        private System.Windows.Forms.Label lbl_segundoValor;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txtbox_primerValor;
        private System.Windows.Forms.TextBox txtbox_segundoValor;
        private System.Windows.Forms.Button btn_resta;
    }
}

