using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (txtbox_clave.Text == "abc123")
            {
                lbl_resultado.Text = "Clave correcta";
                lbl_resultado.BackColor = Color.LightGreen;
            }
            else
            {
                lbl_resultado.Text = "Clave incorrecta";
                lbl_resultado.BackColor = Color.Red;
            }
        }
    }
}
