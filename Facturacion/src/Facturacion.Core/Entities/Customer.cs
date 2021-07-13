namespace Facturacion.Core.Entities
{
    public class Customer : Entity
    {
        public string FullName { get; set; }

        /// <summary>
        /// cedula
        /// </summary>
        public string GvmtId { get; set; }

        public string Cuenta { get; set; }
    }
}
