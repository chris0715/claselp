using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Core
{
    public static class ClassExtensions
    {
        public static bool EqualIgnoreCase(this string content1 , string content2) => content1.Equals(content2, StringComparison.OrdinalIgnoreCase);
        public static bool IsBlank(this string content1) => string.IsNullOrEmpty(content1) || string.IsNullOrWhiteSpace(content1);
    }
}
