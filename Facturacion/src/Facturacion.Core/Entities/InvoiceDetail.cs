namespace Facturacion.Core.Entities
{
    public class InvoiceDetail : Entity
    {
        public int InvoiceId { get; set; }

        public int Entry { get; set; }

        public int ItemId { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Amount { get; set; }
    }
}
