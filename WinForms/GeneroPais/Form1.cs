using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneroPais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            //if (rdbtn_male.Checked == true && rdbtn_country1.Checked == true)
            //    lbl_result.Text = "Es hombre, de " + rdbtn_country1;
            //else if (rdbtn_male.Checked == true && rdbtn_country2.Checked == true)
            //    lbl_result.Text = "Es hombre, de Brasil";
            //else if (rdbtn_male.Checked == true && rdbtn_country3.Checked == true)
            //    lbl_result.Text = "Es hombre, de Uruguay";
            //else if (rdbtn_male.Checked == true && rdbtn_country4.Checked == true)
            //    lbl_result.Text = "Es hombre, de Chile";
            //else if (rdbtn_female.Checked == true && rdbtn_country1.Checked == true)
            //    lbl_result.Text = "Es mujer, de Argentina";
            //else if (rdbtn_female.Checked == true && rdbtn_country2.Checked == true)
            //    lbl_result.Text = "Es mujer, de Brasil";
            //else if (rdbtn_female.Checked == true && rdbtn_country3.Checked == true)
            //    lbl_result.Text = "Es mujer, de Uruguay";
            //else if (rdbtn_female.Checked == true && rdbtn_country4.Checked == true)
            //    lbl_result.Text = "Es mujer, de Chile";
            string pepe = "";
            if (rdbtn_male.Checked)
                pepe = "Es " + rdbtn_male.Text;
            else
                pepe = "Es " + rdbtn_female.Text;
            if (rdbtn_country1.Checked)
                pepe += " de " + rdbtn_country1.Text;
            else if (rdbtn_country2.Checked)
                pepe += " de " + rdbtn_country2.Text;
            else if (rdbtn_country3.Checked)
                pepe += " de " + rdbtn_country3.Text;
            else if (rdbtn_country4.Checked)
                pepe += " de " + rdbtn_country4.Text;
            lbl_result.Text = pepe;
        }
    }
}
