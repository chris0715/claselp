namespace Facturacion.Core.Entities
{
    public class PaymentCondition : Entity
    {
        public string Description { get; set; }

        public int Days { get; set; }
    }
}
