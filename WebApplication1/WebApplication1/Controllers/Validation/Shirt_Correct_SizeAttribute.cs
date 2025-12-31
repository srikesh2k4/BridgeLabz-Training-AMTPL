using System.ComponentModel.DataAnnotations;
using WebApplication1.Model;

namespace WebApplication1.Controllers.Validation;

public class Shirt_Correct_SizeAttribute:ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var shirt = validationContext.ObjectInstance as Shirts;
        if (shirt is not null)
        {
            
        }
    }
}