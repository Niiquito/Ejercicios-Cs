namespace Ejercicio17;
public class Ejercicio17
{
    static void Main()
    {
        Opciones();
        int?[] numeros = new int?[5];
        int ingresoNumeros = 1;
        int opcion = 1, numeroBuscar = 0, index = 0;
        int? maximo = 0, minimo = 0;
        do
        {
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine();
                    do
                    {
                        if (index == numeros.Length)
                        {
                            Console.WriteLine("Base de datos llena");
                            break;
                        }
                        ingresoNumeros = int.Parse(Console.ReadLine());
                        if (ingresoNumeros > 0)
                        {
                            numeros[index] = ingresoNumeros;
                            index++;
                        }
                    } while (ingresoNumeros != 0);
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    for (int i = 0; i < numeros.Length; i++)
                        Console.WriteLine(numeros[i]);
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.Write("Ingrese el numero a buscar: ");
                    numeroBuscar = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        if (numeroBuscar == numeros[i])
                        {
                            Console.WriteLine("El numero existe");
                        }
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    float? suma = 0;
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        if (numeros[i] is not null)
                        {
                            suma += numeros[i];
                        }
                    }
                        minimo = numeros.Min();
                        maximo = numeros.Max();
                    estadisticas(index, maximo, minimo, suma);
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    Console.WriteLine();
                    break;
            }
        } while (opcion !=5);
    }

    private static void estadisticas(int index, int? maximo, int? minimo, float? suma)
    {
        Console.WriteLine($"La suma de todos los valores es: {suma} \n" +
                            $"La media de todos los valores es: {suma / index} \n" +
                            $"La cantidad de valores es: {index} \n" +
                            $"El mínimo es {minimo} \n" +
                            $"El máximo es {maximo} \n");
    }

    private static void Opciones()
    {
        Console.WriteLine("1: Añadir \n" +
                    "2: Ver\n" +
                    "3: Buscar\n" +
                    "4: Estadísticas\n" +
                    "5: Salir\n");
    }
}