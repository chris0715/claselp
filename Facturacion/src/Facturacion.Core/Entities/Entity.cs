namespace Facturacion.Core.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public bool Active { get; set; }

        public int CreatedBy { get; set; }

        public System.DateTime CreatedOn { get; set; }

        public int ModifiedBy { get; set; }

        public System.DateTime ModifiedOn { get; set; }
    }
}
