namespace Facturacion.Core.Entities
{
    public class Invoice : Entity
    {
        public int CustomerId { get; set; }

        public int SellerId { get; set; }

        public int PaymentMethodId { get; set; }

        public string PaymentInputValue { get; set; }

        public string Comments { get; set; }

        public System.DateTime ProcessedOn { get; set; }

        public System.Collections.Generic.IList<InvoiceDetail> Items { get; set; }
    }
}
