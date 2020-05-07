using System.ComponentModel;

namespace DigiCommerce.Core.Domain.Categories
{
    public enum DisplayArea
    {
        [Description("ProductsSection")]
        ProductsSection,
        [Description("BlogSection")]
        BlogSection,
        [Description("Both")]
        Both
    }
}