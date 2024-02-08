namespace Entities
{
    public class Pasajero
    {
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte Edad
        {
            get
            {
                int edad = DateTime.Now.Year - FechaNacimiento.Year;
                return (byte)edad;
            }
        }
        public Pasajero()
        {
            Nombre = Nombre;
            Dni = Dni;
            FechaNacimiento = FechaNacimiento;
        }

    }
}