namespace Entities
{
    public class Linea
    {
        public ushort codigoArea { get; set; }
        public uint numero { get; set; }
        public string Estado { get; private set; }
        public Linea(ushort codigoArea, uint numero)
        {
            if (codigoArea >= 100 && codigoArea <= 9999)
                this.codigoArea = codigoArea;
            if (numero >= 100000 && numero <= 9999999)
                this.numero = numero;
        }
        public void Suspender()
        {
            Estado = "Suspendida";
        }
        public void Reactivar()
        {
            Estado = "Activa";
        }
    }
}