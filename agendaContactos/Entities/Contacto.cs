namespace Entities
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public List<Contacto> Contactos;
        public Contacto()
        {

        }
        public Contacto(string nombre, string apellido, int telefono, string email, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
        }
        public void agregarContacto(Contacto contacto)
        {
            Contactos.Add(contacto);
        }
        public List<Contacto> verContacto()
        {
            return Contactos;
        }
        public void editarContacto(Contacto contacto)
        {
            Console.WriteLine("Que desea modificar");
            Console.WriteLine($"Nombre: {contacto.Nombre}\n" +
                $"Apellido: {contacto.Apellido}\n" +
                $"Telefono: {contacto.Telefono}\n" +
                $"Email: {contacto.Email}\n" +
                $"Direccion: {contacto.Direccion}\n");
            string opc = Console.ReadLine();
            var index = 0;
            switch (opc)
            {
                case "N":
                    index = Contactos.IndexOf(contacto.Nombre);
                    break;
                default:
                    break;
            }
        }
    }
}