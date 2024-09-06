using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FineCar.Validators
{
    public class EstonianPersonalCodeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var personalCode = value as string;

            if (personalCode == null || !Regex.IsMatch(personalCode, @"^\d{11}$"))
            {
                return new ValidationResult("Personal code must consist of exactly 11 digits.");
            }

            if (!IsValidPersonalCode(personalCode))
            {
                return new ValidationResult("Invalid personal code format.");
            }

            return ValidationResult.Success;
        }

        private bool IsValidPersonalCode(string personalCode)
        {

            int genderCentury = int.Parse(personalCode.Substring(0, 1));
            if (genderCentury < 1 || genderCentury > 6)
            {
                return false;
            }

            int year = int.Parse(personalCode.Substring(1, 2));
            int month = int.Parse(personalCode.Substring(3, 2));
            int day = int.Parse(personalCode.Substring(5, 2));

            if (genderCentury == 1 || genderCentury == 2)
            {
                year += 1800;
            }
            else if (genderCentury == 3 || genderCentury == 4)
            {
                year += 1900;
            }
            else if (genderCentury == 5 || genderCentury == 6)
            {
                year += 2000;
            }
            else
            {
                return false;
            }

            try
            {
                var birthDate = new DateTime(year, month, day);
            }
            catch (Exception)
            {
                return false;
            }

            int[] weightsFirst = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int[] weightsSecond = { 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };

            int sumFirst = 0;
            for (int i = 0; i < 10; i++)
            {
                sumFirst += (personalCode[i] - '0') * weightsFirst[i];
            }

            int controlNumber = sumFirst % 11;
            if (controlNumber < 10)
            {
                return controlNumber == personalCode[10] - '0';
            }

            int sumSecond = 0;
            for (int i = 0; i < 10; i++)
            {
                sumSecond += (personalCode[i] - '0') * weightsSecond[i];
            }

            controlNumber = sumSecond % 11;
            if (controlNumber == 10)
            {
                controlNumber = 0;
            }

            return controlNumber == personalCode[10] - '0';
        }
    }
}