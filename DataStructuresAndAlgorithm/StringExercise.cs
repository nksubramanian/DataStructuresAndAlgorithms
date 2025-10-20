using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    internal class StringExercise
     { 
        int GetLength(string input)
        {
            if (input == string.Empty)
                return 0;
            return 1 + GetLength(input.Substring(1));

        }

        public void main()
        {
            var length = GetLength("subramanian");
            Console.WriteLine(length);
        }

    }
}
