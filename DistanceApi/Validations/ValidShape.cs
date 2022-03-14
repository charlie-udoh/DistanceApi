using System.ComponentModel.DataAnnotations;

namespace DistanceApi.Validations
{
    public class ValidShape : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shapes = Constants.Shapes;
            if (shapes.Length > 0 && shapes.Contains(value))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Shape is invalid. Valid shapes include Flat, Spherical and Ellipsoid");
        }
    }
}
