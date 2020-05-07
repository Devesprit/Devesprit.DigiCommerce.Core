using System.ComponentModel;

namespace DigiCommerce.Core.Domain
{
    public enum MatchType
    {
        [Description("Exact Match")]
        Exact,
        [Description("Regular Expressions")]
        Regex,
        [Description("Wildcards")]
        Wildcards
    }
}