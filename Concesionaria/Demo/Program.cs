using Entities;
public class Demo
{
    static void Main()
    {
        Concesionaria concesionaria = new Concesionaria();
        Coche coche0 = new Coche(0, "Toyota", 200, 15300);
        Coche coche1 = new Coche(1, "Ferrari", 0, 30000);
        Coche coche2 = new Coche(2, "Honda", 50000, 15000);
        Coche coche3 = new Coche(3, "Aston Martin", 1000, 25000);
        concesionaria.addCoche(coche0);
        concesionaria.addCoche(coche1);
        concesionaria.addCoche(coche2);
        concesionaria.addCoche(coche3);
        mostrarCoches(concesionaria);
        concesionaria.removeCoche(coche0);
        Console.WriteLine("SIN COCHE0\n");
        mostrarCoches(concesionaria);
        concesionaria.removeAll();
        Console.WriteLine("SIN COCHES\n");
        mostrarCoches(concesionaria);

    }

    private static void mostrarCoches(Concesionaria concesionaria)
    {
        foreach (Coche coche in concesionaria.getCoche())
        {
            Console.WriteLine($"ID: {coche.Id}\n" +
            $"Marca: {coche.Marca}\n" +
            $"KM: {coche.KM}\n" +
            $"Precio: {coche.Precio}\n\n");
        }
    }
}