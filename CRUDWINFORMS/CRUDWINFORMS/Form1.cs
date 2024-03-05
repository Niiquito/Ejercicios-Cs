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
namespace CRUDWINFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }
        #region Metodos
        private void refrescarTabla()
        {
            using (editoEntities db = new editoEntities())
            {
                var lst = from dbo in db.Editorial
                          select new {ID =dbo.editorialID ,Editorial=dbo.editorialNombre, Ciudad=dbo.ciudad, Estado=dbo.estado, Pais=dbo.pais};
                dataView.DataSource = lst.ToList();
            }
        }
        private int? GetID()
        {
            try
            {
                return int.Parse(dataView.Rows[dataView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            Presentation.tablaEditorial tablaEditorial = new Presentation.tablaEditorial();
            tablaEditorial.ShowDialog();
            refrescarTabla();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int? id = GetID();
            if (id != null)
            {
                using (editoEntities db = new editoEntities())
                {
                    Editorial tabla = db.Editorial.Find(id);
                    db.Editorial.Remove(tabla);
                    db.SaveChanges();
                }
                refrescarTabla();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int? id = GetID();
            if(id != null)
            {
                Presentation.tablaEditorial tablaEditorial = new Presentation.tablaEditorial(id);
                tablaEditorial.ShowDialog();
                refrescarTabla();
            }
        }
    }
}
