using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Carrito
    {
        public List<Videojuego> VideojuegoList;
        public decimal PrecioTotal { get; set; }
        public Carrito()
        {
            VideojuegoList = new List<Videojuego>();
        }
        public void agregarJuego(Videojuego videojuego)
        {
            VideojuegoList.Add(videojuego);
        }
        public List<Videojuego> verJuegos()
        {
            return VideojuegoList;
        }
        public void removerJuego(Videojuego videojuego)
        {
            VideojuegoList.Remove(videojuego);
        }
        public void calcularPrecioTotal(Carrito carrito)
        {
            decimal suma = 0;
            foreach (Videojuego item in carrito.verJuegos())
            {
                suma += item.Precio; 
            }
            Console.WriteLine($"Precio total: {suma}");
        }
    }
}
