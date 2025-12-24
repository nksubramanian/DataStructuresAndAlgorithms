using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    internal class Permutations
    {
        private List<string> joinStrings(string element, List<string> strings)
        {
            if (strings.Count == 0)
                return new List<string> { element };
            return strings.Select(s=>element+s).ToList();
        }

        public List<string> GetPermutations(List<string> characters)
        {
            if (characters.Count == 0)
                return new List<string>();  

            List<string> result = new List<string>();
            for (int i = 0; i < characters.Count; i++)
            {
                var remainingCharacters = characters.Where((item, index) => index != i).ToList();
                var permutation = joinStrings(characters[i], GetPermutations(remainingCharacters));
                result.AddRange(permutation);
            }
            return result;

        }

        public void main()
        {
            List<string> characters = new List<string> { "a", "b", "c"};
            var permutations = GetPermutations(characters);
        }

    }
}
