using System.ComponentModel.DataAnnotations;

namespace DistanceApi.Validations
{
    public class ValidUnitOfLength : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var units = Constants.EarthRadiusUnitOfLength.Keys.ToArray();
            if(units.Length > 0 && units.Contains(value))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Unit of Length is invalid. Valid units include Kilometers, Miles");
        }
    }
}
