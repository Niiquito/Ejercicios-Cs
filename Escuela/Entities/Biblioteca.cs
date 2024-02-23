using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Biblioteca
    {
        private List<Libro> librosList;
        private List<Estudiante> estudiantesList;
        private List<Empleado> empleadoList;

        public Biblioteca()
        {
            librosList = new List<Libro>();
            estudiantesList = new List<Estudiante>();
            empleadoList = new List<Empleado>();
        }
        public void addLibro(Libro libro)
        {
            librosList.Add(libro);
        }
        public List<Libro> getLibros()
        {
            return librosList;
        }
        public void addEstudiante(Estudiante estudiante)
        {
            estudiantesList.Add(estudiante);
        }
        public List<Estudiante> getEstudiante()
        {
            return estudiantesList;
        }
        public void addEmpleado(Empleado empleado)
        {
            empleadoList.Add(empleado);
        }
        public List<Empleado> getEmpleado()
        {
            return empleadoList;
        }
        public int giveBook(Libro libro)
        {
            return libro.stock - 1;
        }
        public int returnStock(Libro libro)
        {
            return libro.stock + 1;
        }
    }
}
