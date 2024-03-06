using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWINFORMS.Presentation
{
    public partial class EditorialCompleta : Form
    {
        public EditorialCompleta()
        {
            InitializeComponent();
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            CRUDWINFORMS.editoriales Editoriales = new CRUDWINFORMS.editoriales();
            Editoriales.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            tablaAutores tablaAutores = new tablaAutores();
            tablaAutores.ShowDialog();
        }
    }
}
