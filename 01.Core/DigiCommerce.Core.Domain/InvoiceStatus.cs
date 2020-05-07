using System.ComponentModel;

namespace DigiCommerce.Core.Domain
{
    public enum InvoiceStatus
    {
        [Description("Pending")]
        Pending,
        [Description("Paid")]
        Paid
    }
}