using System;
using System.Collections.Generic;
using System.Linq;
using Katas.Base;
using Katas.Models;

namespace Katas.Linq
{
    public class LinqKatas : KatasBase
    {
        // #1 return the largest int in the list, or zero if the list is empty

        public int GetLargestNum(List<int> nums)
        {
            return 0;
        }

        // #2 return the first person in list, or null if the list is empty

        public Person GetFirstPerson(List<Person> people)
        {
            return null;
        }

        // #3 return the first person in list who is above a given height, or null if there's no match

        public Person GetFirstPersonOver(List<Person> people, int heightCM)
        {
            return null;
        }

        // #4 return the only person with this name, or null if none/multiple found

        public Person GetPersonByFirstName(List<Person> people, string firstName)
        {
            return null;
        }

        // #5 return a boolean to indicate if there is at least one person with this name

        public bool CheckIfPersonExists(List<Person> people, string firstName)
        {
            return false;
        }

        // #6 return the surnames of all people

        public IEnumerable<string> GetSurnames(List<Person> people)
        {
            return null;
        }

        // #7 return the first names of all people with a given surname 

        public IEnumerable<string> GetAllFirstNamesOfFamilyMembers(List<Person> people, string surname)
        {
            return null;
        }

        // #8 return the people ordered by their height ascending

        public IEnumerable<Person> OrderPeopleByHeight(List<Person> people)
        {
            return null;
        }

        // #9 return average height of people or 0 if empty

        public float CalculateAverageHeight(List<Person> people)
        {
            return 0;
        }

        // #10 return a dictionary of id/"firstName+surname" key/vvalue pairs

        public Dictionary<Guid, string> CustomerDictionary(List<Person> people)
        {
            return null;
        }

        // #11 returns a boolean that tell us if all people are over a certain height

        public bool CheckAllPeopleTallEnough(List<Person> people, int heightCM)
        {
            return false;
        }

        // #12 returns a list of people de-duplicated by surname (max one of each family member)

        public List<Person> GetFirstOfEachFamily(List<Person> people)
        {
            return null;
        }

        // #13 return people grouped by surname

        public IDictionary<string, List<Person>> GroupIntoFamilies(List<Person> people)
        {
            return null;
        }

        // #14

        public Dictionary<string, int> TwitterFeedAnalysis(IEnumerable<string> twitterFeed)
        {
            return null;
        }

        // #15

        public List<User> UpdateUserNotes(IEnumerable<User> users, IEnumerable<Note> updatedNotes)
        {
            return null;
        }

        // #16

        public Dictionary<string, List<string>> CategoriseCustomerIds(List<Person> customers, List<Guid> currentGuids)
        {
            return null;
        }

        // #17

        public Artwork[] TriageArtworks(List<Artwork> submissions, DateTime cutoffDate)
        {
            return null;
        }

        // #18 return a dictionary of string/surname + float/avg height for customers with surname <"Jones", 180cm>

        // #19 hashset - improve description

        // #20 return the Id of the tallest member of each family
    }
}
