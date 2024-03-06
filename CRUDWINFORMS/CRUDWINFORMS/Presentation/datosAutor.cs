using CRUDWINFORMS.Models;
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
    public partial class datosAutor : Form
    {
        private int? id;
        private Autor autor;
        public datosAutor(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargarDatos();
        }

        private void CargarDatos()
        {
            using (editoEntities db = new editoEntities())
            {
                autor = db.Autor.Find(id);
                txtNombre.Text = autor.autorNombre;
                txtApellido.Text = autor.autorApellido;
                txtTelefono.Text = autor.telefono;
                txtDireccion.Text = autor.direccion;
                txtCiudad.Text = autor.ciudad;
                txtEstado.Text = autor.estado;
                txtPostal.Text = autor.codigoPostal;
                txtContratado.Text = Convert.ToString(autor.contratado);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (editoEntities db = new editoEntities())
            {
                if (id == null)
                    autor = new Autor();
                autor.autorNombre = txtNombre.Text;
                autor.autorApellido = txtApellido.Text;
                autor.telefono = txtTelefono.Text;
                autor.direccion = txtDireccion.Text;
                autor.ciudad = txtCiudad.Text;
                autor.estado = txtEstado.Text;
                autor.codigoPostal = txtPostal.Text;
                autor.contratado = Convert.ToByte(txtContratado.Text);
                if (id == null)
                    db.Autor.Add(autor);
                else
                    db.Entry(autor).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
