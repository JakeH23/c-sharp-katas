using System;
using System.Collections.Generic;
using Katas.Base;
using Katas.Models;

// you'll need to write your own tests for these babies

namespace Katas.Linq
{
    public class LinqExtras : KatasBase
    {

        // #16 return a single string made up of the first character of each first name + surname

        public string BuildStringFromInitials(List<Person> people)
        {
            return null;
        }

        // #17 return a dictionary of surname + avg height of all people with that surname

        public Dictionary<string, float> AverageHeights(List<Person> people)
        {
            return null;
        }

        // #18 return the ids of the tallest member of each family

        public IEnumerable<Guid> TallestFamilyMembers(List<Person> people)
        {
            return null;
        }

        // #19 return the most common surname in the list
        // if there's a draw between two surnames, return the surname that has the most characters in all of the first names

        public string DominantFamily(List<Person> people)
        {
            return null;
        }

        // #20 flatten the list

        public List<int> Flatten(List<List<int>> deepList)
        {
            return null;
        }
    }
}
