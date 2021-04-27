using System;
using System.Collections.Generic;
using Katas.Base;
using Katas.Models;

namespace Katas.Linq
{
    public class LinqKatas : KatasBase
    {
        // #1
        // return the largest int in the list
        // return zero if the list is empty

        public int GetLargestNum(List<int> ints)
        {
            return 0;
        }

        // #2
        // return the first person in the list
        // return null if the list is empty

        public Person GetFirstPerson(List<Person> people)
        {
            return null;
        }

        // #3
        // return the first person in list who is above a given height
        // return null if there's no match

        public Person GetFirstPersonOver(List<Person> people, int heightCM)
        {
            return null;
        }

        // #4
        // return the only person with a given name
        // return null if none/multiple found

        public Person GetPersonByFirstName(List<Person> people, string firstName)
        {
            return null;
        }

        // #5
        // return a boolean to indicate if there is at least one person with this name

        public bool CheckIfPersonExists(List<Person> people, string firstName)
        {
            return false;
        }

        // #6
        // return the surnames of all people

        public IEnumerable<string> GetSurnames(List<Person> people)
        {
            return null;
        }

        // #7
        // return the first names of all people with a given surname 

        public IEnumerable<string> GetAllFirstNamesOfFamilyMembers(List<Person> people, string surname)
        {
            return null;
        }

        // #8
        // return the people ordered by their height ascending

        public IEnumerable<Person> OrderPeopleByHeight(List<Person> people)
        {
            return null;
        }

        // #9
        // return average height of people
        // return 0 if empty

        public float CalculateAverageHeight(List<Person> people)
        {
            return 12345;
        }

        // #10
        // return a dictionary of id/"firstName+surname" key/value pairs

        public Dictionary<Guid, string> PersonDictionary(List<Person> people)
        {
            return null;
        }

        // #11
        // return a boolean that tell us if all people are over a certain height

        public bool CheckAllPeopleTallEnough(List<Person> people, int heightCM)
        {
            return true;
        }

        // #12
        // return people de-duplicated by surname

        public List<Person> GetFirstOfEachFamily(List<Person> people)
        {
            return null;
        }

        // #13
        // return people grouped by surname

        public IDictionary<string, List<Person>> GroupIntoFamilies(List<Person> people)
        {
            return null;
        }

        // #14 hashset of ids

        public HashSet<Guid> GenerateHashSetOfIds(List<Person> people)
        {
            return null;
        }

        // #15 merge + deduplicate two lists

        public IEnumerable<int> MergeAndDedupe(List<int> list1, List<int> list2)
        {
            return null;
        }
    }
}
