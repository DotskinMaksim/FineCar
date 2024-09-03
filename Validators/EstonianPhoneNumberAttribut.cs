using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace FineCar.Validators
{
    public class EstonianPhoneNumberAttribut : ValidationAttribute
    {


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var phoneNumber = value as string;

            // Проверка на null и формат эстонского номера машины
            if (phoneNumber == null || (phoneNumber.Length != 7 && phoneNumber.Length != 8))
            {
                return new ValidationResult("Неверный формат номера автомобиля. Допустимый формат: 3 буквы и 3 цифры (например, ABC-123).");
            }

            return ValidationResult.Success;
        }


    }
}