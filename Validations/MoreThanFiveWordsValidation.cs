using Microsoft.AspNetCore.Razor.Language.Intermediate;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace la_mia_pizzeria_post.Validations
{
    public class MoreThanFiveWordsValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string fieldValue = value as string;

            int wordsNumber = fieldValue.Trim().Split(' ').Length;

            if (fieldValue != null && wordsNumber < 5)
            {
                return new ValidationResult("Il campo deve contenere almeno 5 parole");
            }

            return ValidationResult.Success;
        }
    }
}
