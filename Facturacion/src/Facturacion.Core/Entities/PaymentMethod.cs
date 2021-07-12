namespace Facturacion.Core.Entities
{
    public class PaymentMethod : Entity
    {
        public string Description { get; set; }

        public bool RequiresInput { get; set; }

        public string InputTitle { get; set; }
    }
}
