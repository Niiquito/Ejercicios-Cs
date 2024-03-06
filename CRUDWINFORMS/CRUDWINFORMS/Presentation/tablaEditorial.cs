using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWINFORMS.Models;
namespace CRUDWINFORMS.Presentation
{
    public partial class tablaEditorial : Form
    {
        private int? id;
        private Editorial editorialTabla;
        public tablaEditorial(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            if (id!=null)
                CargaDatos();
        }
        #region Metodos
        private void CargaDatos()
        {
            using (editoEntities db = new editoEntities())
            {
                editorialTabla = db.Editorial.Find(id);
                txtNombre.Text = editorialTabla.editorialNombre;
                txtCiudad.Text = editorialTabla.ciudad;
                txtEstado.Text = editorialTabla.estado;
                txtPais.Text = editorialTabla.pais;
            }
        }
        #endregion
        private void tablaEditorial_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (editoEntities db = new editoEntities())
            {
                if(id==null)
                    editorialTabla = new Editorial();
                editorialTabla.editorialNombre = txtNombre.Text;
                editorialTabla.ciudad = txtCiudad.Text;
                editorialTabla.estado = txtEstado.Text;
                editorialTabla.pais = txtPais.Text;
                if (id == null)
                    db.Editorial.Add(editorialTabla);
                else
                    db.Entry(editorialTabla).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
