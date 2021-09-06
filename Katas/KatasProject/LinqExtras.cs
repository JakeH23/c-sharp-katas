using System;
using System.Collections.Generic;
using System.Linq;
using Katas.Base;
using Katas.Models;

namespace Katas.Linq
{
    public class LinqExtras : KatasBase
    {
        public string BuildStringFromInitials(List<Person> people)
        {
            return string.Join("", people.Select(x => x.FirstName.Substring(0, 1) + x.Surname.Substring(0, 1)));
        }

        public Dictionary<string, float> AverageHeights(List<Person> people)
        {
            return people.GroupBy(x => x.Surname).ToDictionary(x => x.Key, y => (float)y.Average(z => z.HeightCM));
        }

        public IEnumerable<Guid> TallestFamilyMembers(List<Person> people)
        {
            return people.GroupBy(x => x.Surname).Select(x => x.OrderByDescending(y => y.HeightCM).First().Id);
        }

        public string DominantFamily(List<Person> people)
        {
            return null;
        }

        public List<int> Flatten(List<List<int>> deepList)
        {
            return null;
        }
    }
}
