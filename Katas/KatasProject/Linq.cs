using System;
using System.Collections.Generic;
using Katas.Base;
using Katas.Models;

namespace Katas.Linq
{
    public class LinqKatas : KatasBase
    {
        public int GetLargestNum(List<int> ints)
        {
            return 0;
        }

        public Person GetFirstPerson(List<Person> people)
        {
            return null;
        }

        public Person GetFirstPersonOver(List<Person> people, int heightCM)
        {
            return null;
        }

        public Person GetPersonByFirstName(List<Person> people, string firstName)
        {
            return null;
        }

        public bool CheckIfPersonExists(List<Person> people, string firstName)
        {
            return false;
        }

        public IEnumerable<string> GetSurnames(List<Person> people)
        {
            return null;
        }

        public IEnumerable<string> GetAllFirstNamesOfFamilyMembers(List<Person> people, string surname)
        {
            return null;
        }

        public IEnumerable<Person> OrderPeopleByHeight(List<Person> people)
        {
            return null;
        }

        public float CalculateAverageHeight(List<Person> people)
        {
            return 12345;
        }

        public Dictionary<Guid, string> PersonDictionary(List<Person> people)
        {
            return null;
        }

        public bool CheckAllPeopleTallEnough(List<Person> people, int heightCM)
        {
            return true;
        }

        public List<Person> GetFirstOfEachFamily(List<Person> people)
        {
            return null;
        }

        public IDictionary<string, List<Person>> GroupIntoFamilies(List<Person> people)
        {
            return null;
        }

        public HashSet<Guid> GenerateHashSetOfIds(List<Person> people)
        {
            return null;
        }

        public IEnumerable<int> MergeAndDedupe(List<int> list1, List<int> list2)
        {
            return null;
        }
    }
}
