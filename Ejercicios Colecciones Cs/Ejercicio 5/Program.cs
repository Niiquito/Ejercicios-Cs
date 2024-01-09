namespace Ejercicio5;
public class Ejercicio5
{
    /*Crear una lista de palabras y, a continuación, 
      realizar las siguientes operaciones:
            Mostrar la lista en consola.
            Eliminar todas las palabras que sean menores de 5 caracteres.
            Añadir una nueva palabra al principio de la lista.
            Ordenar la lista alfabéticamente.
    */
    static void Main()
    {
        List<string> palabras = new List<string>();
        palabras.Add("Holas");
        palabras.Add("Petardo");
        palabras.Add("Piña");
        string palabra = "";
        foreach (string item in palabras)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        for (int i = 0; i<palabras.Count; i++)
        {
            palabra = palabras[i];
            if (palabra.Length < 5)
            {
                palabras.RemoveAt(i);
                i--;
            }
        }
        palabras.Add("Cascanueces");
        palabras.Sort();
        foreach(string item in palabras)
        {
            Console.WriteLine(item);
        }
    }
}