using Entities;
public class Demo
{
    static void Main()
    {
        Carrito carrito = new Carrito();
        Videojuego videojuego0 = new Videojuego("Fallout", 10, "Terror", "PC");
        Videojuego videojuego1 = new Videojuego("Fala", 10, "Terror", "PC");
        carrito.agregarJuego(videojuego0);
        carrito.agregarJuego(videojuego1);
        Usuario usuario0 = new Usuario("Pepe");
        usuario0.comprarJuego(videojuego0);
        usuario0.comprarJuego(videojuego1);
        foreach (Videojuego item in carrito.verJuegos())
        {
            Console.WriteLine($"Nombre: {item.Nombre}\n" +
                $"Precio: {item.Precio}\n");
        }
        Console.WriteLine("Historial de compras");
        Console.WriteLine($"Usuario: {usuario0.Nombre}");
        foreach (Videojuego item in usuario0.verJuegos())
        {
            Console.Write($"Juego: {item.Nombre}\n");
        }
        Console.WriteLine();
        carrito.calcularPrecioTotal(carrito);
    }
}