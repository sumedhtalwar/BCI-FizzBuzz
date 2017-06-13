using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FizzBuzzApp.Helper
{
    public static class Extension
    {
        /// <summary>
        /// Extension method to validate user input.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ValidateInputFizzBuzz(this string value)
        {
            var result = false;

            var regexToMatch = new Regex(@"^[0-9]*$");

            if (value != "0" && !string.IsNullOrEmpty(value) && regexToMatch.IsMatch(value))
                result = true;
            return result;

        }
        /// <summary>
        ///Divide by zero check before computing
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ValidateInputFizzBuzz(this int value)
        {
            var result = false;
            if (value != 0)
                result = true;
            return result;

        }
    }
}
