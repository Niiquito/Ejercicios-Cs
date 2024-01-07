namespace Ejercicio8;
public class Ejercicio8
{
    static void Main()
    {
        //Ingresar un dia y un mes (numericos),
        //luego informar cantidad de dias restantes hasta fin de año
        int[] meses = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.Write("Ingrese el mes: ");
        int mes = Convert.ToInt16(Console.ReadLine());
        Console.Write("Ingrese el día: ");
        int dia = Convert.ToInt16(Console.ReadLine());
        int diasRestantes = 0;
        for (int i = mes -1; i < meses.Length; i++)
            diasRestantes+= meses[i];
        Console.WriteLine($"Días que quedan: {diasRestantes - dia}");
    }
}