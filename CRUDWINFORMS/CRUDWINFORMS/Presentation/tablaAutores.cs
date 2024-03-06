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
    public partial class tablaAutores : Form
    {
        public tablaAutores()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            datosAutor datosAutor = new datosAutor();
            datosAutor.ShowDialog();
            RefrescarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaAutores_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
        }
        private void RefrescarTabla()
        {
            using (editoEntities db = new editoEntities())
            {
                var lst = from dbo in db.Autor
                          select new
                          {
                              ID = dbo.autorID,
                              Nombre = dbo.autorNombre,
                              Apellido = dbo.autorApellido,
                              Telefono = dbo.telefono,
                              Direccion = dbo.direccion,
                              Ciudad = dbo.ciudad,
                              Estado = dbo.estado,
                              Contratado = dbo.contratado
                          };
                dataViewAutor.DataSource = lst.ToList();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetID();
            if (id != null)
            {
                datosAutor datosAutor = new datosAutor(id);
                datosAutor.ShowDialog();
                RefrescarTabla();
            }
        }
        private int? GetID()
        {
            try
            {
                return int.Parse(dataViewAutor.Rows[dataViewAutor.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetID();
            if (id != null)
            {
                using (editoEntities db = new editoEntities())
                {
                    Autor autor = db.Autor.Find(id);
                    db.Autor.Remove(autor);
                    db.SaveChanges();
                }
                RefrescarTabla();
            }
        }
    }
}
