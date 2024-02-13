namespace Entities
{
    public class Coche
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public int KM { get; set; }
        public decimal Precio { get; set; }
        public Coche()
        {

        }
        public Coche(int id, string Marca, int km, decimal precio) : this()
        {
            Id = id;
            this.Marca = Marca;
            KM = km;
            Precio = precio;
        }
    }
}