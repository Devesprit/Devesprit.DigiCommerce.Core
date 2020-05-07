using System.ComponentModel;

namespace DigiCommerce.Core.Domain.Products
{
    public enum TimePeriodType
    {
        [Description("Hour")]
        Hour,
        [Description("Day")]
        Day,
        [Description("Month")]
        Month,
        [Description("Year")]
        Year
    }
}
