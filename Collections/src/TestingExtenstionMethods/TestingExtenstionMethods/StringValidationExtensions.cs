using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TestingExtenstionMethods
{
    public static class StringValidationExtensions
    {

        private static readonly Regex PhoneRegex = new Regex(@"^(\+20|0)1[0125]\d{8}$", RegexOptions.Compiled);
        private static readonly Regex NationalIdRegex = new Regex(@"^[23]\d{13}$", RegexOptions.Compiled);

        public static bool IsValidEgyptianPhone(this string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            return PhoneRegex.IsMatch(value);

        }

        public static bool IsValidEgyptianNationalId(this string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            return NationalIdRegex.IsMatch(value);
        }
    }
}
