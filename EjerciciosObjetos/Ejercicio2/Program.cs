using NewCustomer;
public class Ejercicio2
{
    static void Main()
    {
        #region "Variables"
        LinkedList<string> name = new LinkedList<string>();
        LinkedList<int> dni = new LinkedList<int>();
        LinkedList<DateTime> birthDay = new LinkedList<DateTime>();
        LinkedList<string> nationality = new LinkedList<string>();
        LinkedList<UInt16> age = new LinkedList<UInt16>();
        Customer persona = new Customer();
        #endregion
        do
        {
            Console.Write("Nombre: ");
            persona.Name = Console.ReadLine();
            name.AddLast(persona.Name);
            if (persona.Name == "")
            {
                break;
            }
            else
            {
                persona = new Customer(nationality, dni, birthDay);
                dni.AddLast(persona.Dni);
                birthDay.AddLast(persona.BirthDay);
                nationality.AddLast(persona.Nationality);
                age.AddLast(persona.Age);
            }
        } while (persona.Name == "");
        name.RemoveLast();
        Informe(name, dni, birthDay, nationality, age);

    }

    private static void Informe(LinkedList<string> nombre, LinkedList<int> Dni, LinkedList<DateTime> BirthDay, LinkedList<string> Nacionalidad, LinkedList<UInt16> Edad)
    {
        for (int i = 0; i < nombre.Count; i++)
        {
            Console.WriteLine($"Nombre: {nombre.ElementAt(i)}\n" +
                $"DNI: {Dni.ElementAt(i)}\n" +
                $"Fecha Nacimiento: {BirthDay.ElementAt(i)}\n" +
                $"Nacionalidad: {Nacionalidad.ElementAt(i)}\n" +
                $"Edad: {Edad.ElementAt(i)}\n");
        }
    }
}