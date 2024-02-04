using LibreriaObjetos1;
using Account;
static class Ejercicio1
{
    static void Main()
    {
        Customer persona = new Customer();
        Acount cuenta = new Acount();
        List<string> nombre = new List<string>();
        List<int> dni = new List<int>();
        LinkedList<DateTime> fechaNacimiento = new LinkedList<DateTime>();
        List<int> edad = new List<int>();
        LinkedList<int> numeroCuenta = new LinkedList<int>();
        LinkedList<bool> estadoCuenta = new LinkedList<bool>();
        LinkedList<decimal> monto = new LinkedList<decimal>();
        LinkedList<string> nacionalidad = new LinkedList<string>();
        Console.WriteLine("Ingrese nombre, DNI y fecha de nacimiento");
        do
        {
            Console.Write("Nombre: ");
            persona.Name = Console.ReadLine();
            if (persona.Name == "")
                break;
            else
            {
                Console.Write("DNI: ");
                persona.dni = int.Parse(Console.ReadLine());
                Console.Write("Fecha de nacimiento: ");
                persona.BirthDay = DateTime.Parse(Console.ReadLine());
                Console.Write("Numero de cuenta: ");
                cuenta.Number = int.Parse(Console.ReadLine());
                Console.Write("Estado de cuenta: Default True\n");
                cuenta.Enabled = true;
                Console.Write("Monto a depositar: ");
                cuenta.Deposit(decimal.Parse(Console.ReadLine()));
                Console.Write("Monto a retirar: ");
                cuenta.WithDraw(decimal.Parse(Console.ReadLine()));
                monto.AddLast(cuenta.Balance);
                nombre.Add(persona.Name);
                dni.Add(persona.dni);
                fechaNacimiento.AddLast(persona.BirthDay);
                edad.Add(persona.Age);
                numeroCuenta.AddLast(cuenta.Number);
                estadoCuenta.AddLast(cuenta.Enabled);
            }
        } while (persona.Name != "");
        Console.ReadKey();
        Console.Clear();

        for (int i = 0; i < nombre.Count; i++)
            Console.Write($"\nNombre: {nombre[i]}\n" +
                $"DNI: {dni[i]}\n" +
                $"Fecha Nacimiento: {fechaNacimiento.ElementAt(i)}\n" +
                $"Edad: {edad[i]}\n" +
                $"Numero Cuenta: {numeroCuenta.ElementAt(i)}\n" +
                $"Estado Cuenta: {estadoCuenta.ElementAt(i)}\n" +
                $"Balance: {monto.ElementAt(i)}\n" +
                $"Nacionalidad: {nacionalidad.ElementAt(i)}\n");
    }
}