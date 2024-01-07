namespace Ejercicio10;
public class Ejercicio10
{
    //Realiza un programa que introduzca el nombre y la edad de cada alumno.
    //El proceso de lectura de datos terminará cuando se introduzca como nombre un asterisco (*)
    //Al finalizar se mostrará los siguientes datos:
    //Todos lo alumnos mayores de edad.
    //Los alumnos mayores(los que tienen más edad)
    static void Main()
    {
        //string[,] alumnos = new string[5, 2] 
        //{
        //    {"Pedro", "1" },
        //    {"Alita", "2" },
        //    {"Pito", "3" },
        //    {"Gomoso", "4" },
        //    {"Terra", "5" },
        //};
        Console.Write("Ingrese la cantidad de alumnos: ");
        int cantidadAlumnos = Convert.ToInt32(Console.ReadLine());
        string[,] alumnos = new string[cantidadAlumnos, 2];
        //GetLenght(0) indica la fila y GetLenght(1) indica la columna
        //Es decir, en el primer for se va a posicionar en la primera fila
        //Luego en el segundo for se posiciona en la primera columna
        //Ahí empieza a contar desde la primera fila ---- y ingresar datos en las columnas, es decir, 0,1 | 0,2
        ////Una vez terminado ese recorrido vuelve al primer for y cambia a la siguiente fila, es decir 1,0 y va aumentando la columna, 1,1 || 1,2.
        for (int i = 0; i < alumnos.GetLength(0); i++)
        {
            Console.WriteLine("Ingrese nombre y edad del alumno");
            for (int j = 0; j < alumnos.GetLength(1); j++)
            {
                alumnos[i, j] = Console.ReadLine();
            }
        }
        //i = fila = ir abajo
        //j = columna = ir hacia la derecha
        Console.WriteLine();
        for (int i = 0; i < cantidadAlumnos; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(alumnos[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}