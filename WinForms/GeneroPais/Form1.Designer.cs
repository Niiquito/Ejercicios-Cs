namespace GeneroPais
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
            this.gb_genre = new System.Windows.Forms.GroupBox();
            this.gb_country = new System.Windows.Forms.GroupBox();
            this.btn_accept = new System.Windows.Forms.Button();
            this.rdbtn_male = new System.Windows.Forms.RadioButton();
            this.rdbtn_female = new System.Windows.Forms.RadioButton();
            this.rdbtn_country1 = new System.Windows.Forms.RadioButton();
            this.rdbtn_country2 = new System.Windows.Forms.RadioButton();
            this.lbl_result = new System.Windows.Forms.Label();
            this.gb_genre.SuspendLayout();
            this.gb_country.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_genre
            // 
            this.gb_genre.Controls.Add(this.rdbtn_female);
            this.gb_genre.Controls.Add(this.rdbtn_male);
            this.gb_genre.Location = new System.Drawing.Point(72, 63);
            this.gb_genre.Name = "gb_genre";
            this.gb_genre.Size = new System.Drawing.Size(200, 100);
            this.gb_genre.TabIndex = 0;
            this.gb_genre.TabStop = false;
            this.gb_genre.Text = "Genero";
            // 
            // gb_country
            // 
            this.gb_country.Controls.Add(this.rdbtn_country2);
            this.gb_country.Controls.Add(this.rdbtn_country1);
            this.gb_country.Location = new System.Drawing.Point(381, 63);
            this.gb_country.Name = "gb_country";
            this.gb_country.Size = new System.Drawing.Size(200, 100);
            this.gb_country.TabIndex = 1;
            this.gb_country.TabStop = false;
            this.gb_country.Text = "Pais";
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(294, 239);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Text = "Aceptar";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // rdbtn_male
            // 
            this.rdbtn_male.AutoSize = true;
            this.rdbtn_male.Location = new System.Drawing.Point(18, 32);
            this.rdbtn_male.Name = "rdbtn_male";
            this.rdbtn_male.Size = new System.Drawing.Size(62, 17);
            this.rdbtn_male.TabIndex = 0;
            this.rdbtn_male.TabStop = true;
            this.rdbtn_male.Text = "Hombre";
            this.rdbtn_male.UseVisualStyleBackColor = true;
            // 
            // rdbtn_female
            // 
            this.rdbtn_female.AutoSize = true;
            this.rdbtn_female.Location = new System.Drawing.Point(18, 55);
            this.rdbtn_female.Name = "rdbtn_female";
            this.rdbtn_female.Size = new System.Drawing.Size(51, 17);
            this.rdbtn_female.TabIndex = 1;
            this.rdbtn_female.TabStop = true;
            this.rdbtn_female.Text = "Mujer";
            this.rdbtn_female.UseVisualStyleBackColor = true;
            // 
            // rdbtn_country1
            // 
            this.rdbtn_country1.AutoSize = true;
            this.rdbtn_country1.Location = new System.Drawing.Point(23, 32);
            this.rdbtn_country1.Name = "rdbtn_country1";
            this.rdbtn_country1.Size = new System.Drawing.Size(70, 17);
            this.rdbtn_country1.TabIndex = 2;
            this.rdbtn_country1.TabStop = true;
            this.rdbtn_country1.Text = "Argentina";
            this.rdbtn_country1.UseVisualStyleBackColor = true;
            // 
            // rdbtn_country2
            // 
            this.rdbtn_country2.AutoSize = true;
            this.rdbtn_country2.Location = new System.Drawing.Point(23, 55);
            this.rdbtn_country2.Name = "rdbtn_country2";
            this.rdbtn_country2.Size = new System.Drawing.Size(50, 17);
            this.rdbtn_country2.TabIndex = 3;
            this.rdbtn_country2.TabStop = true;
            this.rdbtn_country2.Text = "Brasil";
            this.rdbtn_country2.UseVisualStyleBackColor = true;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(280, 198);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(35, 13);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.gb_country);
            this.Controls.Add(this.gb_genre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_genre.ResumeLayout(false);
            this.gb_genre.PerformLayout();
            this.gb_country.ResumeLayout(false);
            this.gb_country.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_genre;
        private System.Windows.Forms.GroupBox gb_country;
        private System.Windows.Forms.RadioButton rdbtn_female;
        private System.Windows.Forms.RadioButton rdbtn_male;
        private System.Windows.Forms.RadioButton rdbtn_country2;
        private System.Windows.Forms.RadioButton rdbtn_country1;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Label lbl_result;
    }
}

