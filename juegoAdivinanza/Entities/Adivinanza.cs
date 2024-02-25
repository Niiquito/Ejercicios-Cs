namespace Entities
{
    public class Adivinanza
    {
        public Random numeroRandom { get; set; }
        public int Numero { get; set; }
        private int valorRandom = 0;
        public Adivinanza()
        {
            numeroRandom = new Random();
            valorRandom = numeroRandom.Next(1, 10);
        }
        public void adivinanza()
        {
            int numero;
            int intentos = 3;
            //Console.WriteLine($"Valor random: {valorRandom}");
            do
            {
                numero = ingresarValor();
                if (numero == valorRandom)
                {
                    Console.WriteLine("Numero adivinado!");
                    break;
                }
                else if (numero > valorRandom)
                {
                    Console.WriteLine("El numero ingresado es mayor");
                    intentos -= 1;
                }
                else if (numero < valorRandom)
                {
                    Console.WriteLine("El numero ingresado es menor");
                    intentos -= 1;
                }
            } while (intentos != 0);
            if (intentos == 0 && numero != valorRandom)
                Console.WriteLine("Intentos agotados");
        }

        private static int ingresarValor()
        {
            int numero;
            Console.Write("Numero: ");
            numero = int.Parse(Console.ReadLine());
            return numero;
        }
    }
}