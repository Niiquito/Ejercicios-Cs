namespace Ejercicio12;
public class Ejercicio12
{
    //solicite al usuario las notas de 10 alumnos
    //divididos en 2 grupos (es decir, filas) de 5 alumnos en cada uno (es decir, columnas). 
    //Deberás almacenarlos en una matriz bidimensional
    //y mostrar la medía aritmética de cada grupo de alumnos
    static void Main()
    {
        #region "Forma tosca"
        //int[][] notasAlumno = new int[2][];
        //notasAlumno[0] = new int[5];
        //notasAlumno[1] = new int[5];
        //int suma1 = 0, suma2 = 0;
        //Console.WriteLine("Ingrese las notas de los alumnos");
        //for (int i = 0; i < 5; i++)
        //{
        //    notasAlumno[0][i] = Convert.ToInt32(Console.ReadLine()); 
        //    suma1 += notasAlumno[0][i]; 
        //}
        //for (int j = 0;  j < 5;  j++)
        //{
        //    notasAlumno[1][j] = Convert.ToInt32(Console.ReadLine());
        //    suma2 += notasAlumno[1][j];
        //}
        //Console.WriteLine($"El promedio del primer grupo es: {suma1 / notasAlumno[0].Length}");
        //Console.WriteLine($"El promedio del segundo grupo es: {suma2 / notasAlumno[1].Length}");
        #endregion
        #region "Forma 2"
        int[,] notaAlumnos = new int[2, 5];
        ingresoNotas(notaAlumnos);
        mediaAlumnos(notaAlumnos);
        Console.WriteLine();
        informeNotasMatriz(notaAlumnos);
        #endregion
    }
    // i = fila = ir para abajo
    // j = columna = ir a la derecha
    //GetLenght(0) indica la fila y GetLenght(1) indica la columna
    //Es decir, en el primer for se va a posicionar en la primera fila
    //Luego en el segundo for se posiciona en la primera columna
    //Ahí empieza a contar desde la primera fila ---- y ingresar datos en las columnas, es decir, 0,1 | 0,2
    //Una vez terminado ese recorrido vuelve al primer for y cambia a la siguiente fila,
    //es decir 1,0 y va aumentando la columna, 1,1 || 1,2.
    private static void ingresoNotas(int[,] notaAlumnos)
    {
        Console.WriteLine("Ingrese las notas de los alumnos");
        for (int i = 0; i < notaAlumnos.GetLength(0); i++)
        {
            for (int j = 0; j < notaAlumnos.GetLength(1); j++)
            {
                notaAlumnos[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    private static void mediaAlumnos(int[,] notaAlumnos)
    {
        int media = 0;
        for (int i = 0; i < notaAlumnos.GetLength(0); i++)
        {
            for (int j = 0; j < notaAlumnos.GetLength(1); j++)
            {
                media += notaAlumnos[i, j];
            }
            Console.WriteLine($"La media del grupo {i + 1} es: {media / notaAlumnos.GetLength(1)} ");
            media = 0;
        }
    }

    private static void informeNotasMatriz(int[,] notaAlumnos)
    {
        for (int i = 0; i < notaAlumnos.GetLength(0); i++)
        {
            for (int j = 0; j < notaAlumnos.GetLength(1); j++)
            {
                Console.Write(notaAlumnos[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}