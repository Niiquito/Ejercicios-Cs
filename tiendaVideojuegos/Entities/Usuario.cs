namespace Entities
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public List<Videojuego> historialCompras { get; set; }
        public Usuario()
        {
            historialCompras = new List<Videojuego>();
        }
        public Usuario(string nombre) :this()
        {
            this.Nombre = nombre;
        }
        public void comprarJuego(Videojuego videojuego)
        {
            historialCompras.Add(videojuego);
        }
        public List<Videojuego> verJuegos()
        {
            return historialCompras;
        }

    }
}