using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Lab5.Attributes
{
    public class AddressAttribute: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string input = value.ToString();
            return Regex.IsMatch(input, "^\\w+,\\w+,\\w+$", RegexOptions.IgnoreCase);
        }
    }
}
