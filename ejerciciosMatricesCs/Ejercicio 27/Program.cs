namespace Ejercicio27;
public class Ejercicio27
{
    static void Main()
    {
        #region "Variables"
        string[] alumno = new string[3];
        int[,] notas = new int[alumno.Length, alumno.Length];
        float[] sumaAlumno = new float[alumno.Length];
        float sumaGeneral = 0;
        float[] promedioAlumno = new float[alumno.Length];
        float notaMayor = 0, contador = 0;
        #endregion
        Random numeroRandom = new Random();
        ingresoAlumno(alumno);
        asignacionRandom(notas, numeroRandom);
        graficoMatriz(notas, alumno);
        Console.WriteLine("\n");
        sumaGeneral = obtenerSumaNotas(notas, sumaAlumno, sumaGeneral);
        Console.WriteLine();
        obtenerPromedio(alumno, sumaAlumno, promedioAlumno, ref notaMayor, ref contador);
        informarPromedio(alumno, notas, sumaGeneral, notaMayor, contador);
    }

    private static void ingresoAlumno(string[] alumno)
    {
        for (int i = 0; i < alumno.Length; i++)
        {
            Console.Write("Ingrese el nombre del alumno: ");
            alumno[i] = Console.ReadLine();
        }
    }

    private static float obtenerSumaNotas(int[,] notas, float[] sumaAlumno, float sumaGeneral)
    {
        for (int i = 0; i < notas.GetLength(0); i++)
        {
            for (int j = 0; j < notas.GetLength(1); j++)
            {
                sumaAlumno[i] += notas[i, j];
                sumaGeneral += notas[i, j];
            }
        }

        return sumaGeneral;
    }

    private static void informarPromedio(string[] alumno, int[,] notas, float sumaGeneral, float notaMayor, float contador)
    {
        Console.WriteLine($"Promedio General {(sumaGeneral / notas.Length):N2}\n");
        Console.WriteLine($"Promedio Mayor: {notaMayor:N2}");
        Console.WriteLine($"Alumno: {contador}, {alumno[Convert.ToInt16(contador - 1)]}");
    }

    private static void obtenerPromedio(string[] alumno, float[] sumaAlumno, float[] promedioAlumno, ref float notaMayor, ref float contador)
    {
        for (int i = 0; i < sumaAlumno.Length; i++)
        {
            Console.WriteLine($"{alumno[i]} tiene promedio {sumaAlumno[i] / 3:N2}");
            promedioAlumno[i] = sumaAlumno[i] / alumno.Length;
            if (promedioAlumno[i] > notaMayor)
            {
                notaMayor = promedioAlumno[i];
                contador++;
            }
        }
    }

    private static void asignacionRandom(int[,] matriz, Random numeroRandom)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = numeroRandom.Next(1, 10);
            }
    }
    private static void graficoMatriz(int[,] matriz, string[] alumno)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.Write(alumno[i] + "\t");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}