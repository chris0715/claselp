using System.ComponentModel;

namespace Facturacion.Core.Entities
{
    public enum LoginResult
    {
        Success,

        [Description("Nombre de usuario incorrecto.")]
        InvalidUsername,
        
        [Description("Clave incorrecta.")]
        InvalidPassword,
        
        [Description("Su usuario ha sido desactivado.")]
        InactiveUser
    }

    public static class LoginResultExtensions
    {
        public static string GetDescription(this LoginResult item)
            => item.GetType().GetMember(item.ToString())?[0]?.GetCustomAttributes(false)?[0] is DescriptionAttribute d
             ? d.Description : item.ToString();
    }       
}
