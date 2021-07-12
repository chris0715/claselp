namespace Facturacion.Core.Entities
{
    public class Item : Entity
    {
        public string Description { get; set; }

        public double Cost { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }
    }
}
