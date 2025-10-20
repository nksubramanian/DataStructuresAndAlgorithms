using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    internal class NumberExercise
    {
        int getSumOfDigit(int number)
        {
            if(number ==0)
                return 0;
            return number % 10 + getSumOfDigit(number / 10);
        }

        public void main()
        {
            var sum = getSumOfDigit(1432);
            Console.WriteLine(sum);
        }
    }
}
