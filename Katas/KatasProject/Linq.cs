using System;
using System.Collections.Generic;
using System.Linq;
using Katas.Base;
using Katas.Models;

namespace Katas.Linq
{
    public class LinqKatas : KatasBase
    {
        public int GetLargestNum(List<int> ints)
        {
            return ints.DefaultIfEmpty().Max();
        }

        public Person GetFirstPerson(List<Person> people)
        {
            return people.FirstOrDefault();
        }

        public Person GetFirstPersonOver(List<Person> people, int heightCM)
        {
            return people.FirstOrDefault(x => x.HeightCM > heightCM);
        }

        public Person GetPersonByFirstName(List<Person> people, string firstName)
        {
            var names = people.Where(x => x.FirstName == firstName);
            return names.Count() > 1 ? null : names.SingleOrDefault();
        }

        public bool CheckIfPersonExists(List<Person> people, string firstName)
        {
            return people.Any(x => x.FirstName == firstName);
        }

        public IEnumerable<string> GetSurnames(List<Person> people)
        {
            return people.Select(x => x.Surname);
        }

        public IEnumerable<string> GetAllFirstNamesOfFamilyMembers(List<Person> people, string surname)
        {
            return people.Where(x => x.Surname == surname).Select(y => y.FirstName);
        }

        public IEnumerable<Person> OrderPeopleByHeight(List<Person> people)
        {
            return people.OrderBy(x => x.HeightCM);
        }

        public float CalculateAverageHeight(List<Person> people)
        {
            //Both methods work - which way is cleaner though? with or without the cast?
            //return people.Any() ? people.Sum(x => x.HeightCM) / people.Count : 0;
            return people.Any() ? (float)people.DefaultIfEmpty().Average(x => x.HeightCM) : 0;
        }

        public Dictionary<Guid, string> PersonDictionary(List<Person> people)
        {
            return people.ToDictionary(x => x.Id, y => y.FirstName + y.Surname);
        }

        public bool CheckAllPeopleTallEnough(List<Person> people, int heightCM)
        {
            return people.Any() && people.All(x => x.HeightCM > heightCM);
        }

        public List<Person> GetFirstOfEachFamily(List<Person> people)
        {
            return people.GroupBy(x => x.Surname).Select(y => y.OrderBy(e => e.FirstName).First()).ToList();
        }

        public IDictionary<string, List<Person>> GroupIntoFamilies(List<Person> people)
        {
            return people.GroupBy(x => x.Surname).ToDictionary(y => y.Key, z => z.ToList());
        }

        public HashSet<Guid> GenerateHashSetOfIds(List<Person> people)
        {
            return people.Select(x => x.Id).ToHashSet();
        }

        public IEnumerable<int> MergeAndDedupe(List<int> list1, List<int> list2)
        {
            return list1.Union(list2);
        }
    }
}
