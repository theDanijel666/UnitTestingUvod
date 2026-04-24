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

        /// <summary>
        /// Calculates the sum of two integers.
        /// </summary>
        /// <param name="a">The first integer to add.</param>
        /// <param name="b">The second integer to add.</param>
        /// <returns>The sum of the two specified integers.</returns>
        public int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Calculates the result of subtracting one integer from another.
        /// </summary>
        /// <param name="a">The minuend. The value from which <paramref name="b"/> is subtracted.</param>
        /// <param name="b">The subtrahend. The value to subtract from <paramref name="a"/>.</param>
        /// <returns>The result of <paramref name="a"/> minus <paramref name="b"/>.</returns>
        public int Subtract(int a, int b) 
        {
            return a - b;
        }

        /// <summary>
        /// Calculates the product of two integers.
        /// </summary>
        /// <param name="a">The first integer to multiply.</param>
        /// <param name="b">The second integer to multiply.</param>
        /// <returns>The product of the two specified integers.</returns>
        public int Multiply(int a,int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides one integer by another and returns the result as an integer quotient.
        /// </summary>
        /// <param name="a">The dividend. This is the number to be divided.</param>
        /// <param name="b">The divisor. This is the number by which to divide. Must not be zero.</param>
        /// <returns>The integer result of dividing <paramref name="a"/> by <paramref name="b"/>.</returns>
        /// <exception cref="DivideByZeroException">Thrown when <paramref name="b"/> is zero.</exception>
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
            return a / b;
        }
    }
}
