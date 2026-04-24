using System;
using System.Collections.Generic;
using System.Text;

namespace MainApp.Services
{
    public class Calculation
    {
        /// <summary>
        /// Prompts the user with the specified message and reads an integer value from the console input.
        /// </summary>
        /// <param name="message">The message to display to the user before reading input.</param>
        /// <returns>The integer value entered by the user. Returns 0 if the input cannot be parsed as an integer.</returns>
        public int GetNumberFromUSer(string message)
        {
            Console.WriteLine(message);
            int result;
            if(!int.TryParse(Console.ReadLine(), out result))
            {
                return 0;
            }
            return result;
        }

        /// <summary>
        /// Prompts the user to enter a mathematical operator and returns the validated operator character.
        /// </summary>
        /// <remarks>The method continues to prompt the user until a valid operator is entered. Only the
        /// operators '+', '-', '*', and '/' are accepted.</remarks>
        /// <param name="message">The message to display to the user when prompting for input.</param>
        /// <returns>A character representing the operator entered by the user. The value will be one of '+', '-', '*', or '/'.</returns>
        public char GetOperatorFromUser(string message)
        {
            Console.WriteLine(message);
            char op;
            while(!char.TryParse(Console.ReadLine(),out op) || (op!='+' && op!='-' && op!='*' && op != '/'))
            {
                Console.WriteLine("Ivalid operator. Please enter one of the following: +, -, *, /");
            }
            return op;
        }
    }
}
