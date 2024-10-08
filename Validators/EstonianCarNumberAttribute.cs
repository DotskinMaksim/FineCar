﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FineCar.Validators
{
    public class EstonianCarNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var carNumber = value as string;

            if (carNumber == null || !Regex.IsMatch(carNumber, @"^[A-Z]{3}-\d{3}$"))
            {
                return new ValidationResult("Sobimatu sõiduki numbri vorming. Aktsepteeritav formaat: 3 tähte ja 3 numbrit (näiteks ABC-123).");
            }

            return ValidationResult.Success;
        }
    }
}
