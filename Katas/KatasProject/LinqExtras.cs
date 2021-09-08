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
            var peopleDictionary = new Dictionary<string, int>();
            foreach (var person in people)
            {
                if (!peopleDictionary.ContainsKey(person.Surname))
                {
                    var surnameList = people.Where(x => x.Surname == person.Surname);
                    peopleDictionary.Add(person.Surname, surnameList.Count());
                }
            }

            var mostCommonSurnames = peopleDictionary.Where(x => x.Value == peopleDictionary.Values.Max()).ToList();

            switch (mostCommonSurnames.Count)
            {
                case 0:
                    return string.Empty;
                case 1:
                    return mostCommonSurnames.FirstOrDefault().Key;
                default:
                {
                    var peopleFirstNameDictionary = new Dictionary<string, int>();
                    foreach (var person in mostCommonSurnames)
                    {
                        var count = 0;
                        var personList = people.Where(x => x.Surname == person.Key).ToList();
                        foreach (var name in personList)
                        {
                            count += name.FirstName.Length;
                        }
                        peopleFirstNameDictionary.Add(person.Key, count);
                    }

                    return peopleFirstNameDictionary.FirstOrDefault(x => x.Value == peopleFirstNameDictionary.Values.Max()).Key;
                }
            }
        }

        public List<int> Flatten(List<List<int>> deepList)
        {
            return null;
        }
    }
}
