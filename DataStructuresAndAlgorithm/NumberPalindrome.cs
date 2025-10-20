using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    internal class NumberPalindrome
    {

        bool isPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;
            if(input.Length == 1)
                return true;
            else
            {
                return (input[0] == input[input.Length - 1]) &&
                    isPalindrome(input.Substring(1, input.Length - 2));

            }
        }


        public void main()
        {
            var input = "malayalam";
            Console.WriteLine(isPalindrome(input));

        }

    }
}
