using FizzBuzzApp.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    /// <summary>
    /// 
    /// </summary>
    public class FizzBuzzLogic
    {
        /// <summary>
        /// Executes the fizz buzz logic
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string DoFizzBuzz(int input)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                if (input.ValidateInputFizzBuzz())
                {
                    if (input % 3 == 0 && input % 5 == 0) // can replace 3 and 5 values with enviormental values.
                    {
                        sb.Append("FizzBuzz");
                        return sb.ToString();
                    }
                    else if (input % 3 == 0)
                        sb.Append("Fizz");
                    else if (input % 5 == 0)
                        sb.Append("Buzz");

                    else if (sb.Length == 0)
                        sb.Append("1");
                }
               
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return sb.ToString();

        }

    }
}
