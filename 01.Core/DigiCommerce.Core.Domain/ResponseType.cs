using System.ComponentModel;

namespace DigiCommerce.Core.Domain
{
    public enum ResponseType
    {
        [Description("Redirect")]
        Redirect,
        [Description("Rewrite")]
        Rewrite
    }
}