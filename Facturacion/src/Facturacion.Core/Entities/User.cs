namespace Facturacion.Core.Entities
{
    public class User : Entity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public bool IsAdmin { get; set; }
    }
}
