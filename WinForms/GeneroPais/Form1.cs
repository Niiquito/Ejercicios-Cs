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
            if (rdbtn_male.Checked == true && rdbtn_country1.Checked == true)
                lbl_result.Text = "Es hombre, de Argentina";
            else if (rdbtn_male.Checked == true && rdbtn_country2.Checked == true)
                lbl_result.Text = "Es hombre, de Brasil";
            else if (rdbtn_female.Checked == true && rdbtn_country1.Checked == true)
                lbl_result.Text = "Es mujer, de Argentina";
            else if (rdbtn_female.Checked == true && rdbtn_country2.Checked == true)
                lbl_result.Text = "Es mujer, de Brasil";
        }
    }
}
