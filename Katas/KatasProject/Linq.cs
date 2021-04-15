using System;
using System.Collections.Generic;
using System.Linq;
using Katas.Base;
using Katas.Models;

namespace Katas.Linq
{
    public class LinqKatas : KatasBase
    {
        // #1 return the largest int from the list, or zero if empty list
        public int GetLargestNum(List<int> nums)
        {
            return 0;
        }

        // #2 return first customer in list, or null if empty list
        public Customer GetFirstCustomer(List<Customer> customers)
        {
            return null;
        }

        // #3 return first customer in list who is above this height, or null
        public Customer GetFirstCustomerOver(List<Customer> customers, int heightCM)
        {
            return null;
        }

        // #4 returns only customer with this name, or null if none/multiple found

        public Customer GetUniqueCustomerByFirstName(List<Customer> customers, string firstName)
        {
            return null;
        }

        // #5 returns boolean - tells us if there is at least one customer with this name

        public bool CheckIfCustomerExists(List<Customer> customers, string firstName)
        {
            return false;
        }

        // #6 return the surnames of all customers

        public IEnumerable<string> GetSurnames(List<Customer> customers)
        {
            return null;
        }

        // #7 return the first names of all customers with a given surname 

        public IEnumerable<string> GetAllFirstNamesOfFamilyMembers(List<Customer> customers, string surname)
        {
            return null;
        }

        // #8 return the customers ordered by their height ascending

        public IEnumerable<Customer> OrderCustomersByHeight(List<Customer> customers)
        {
            return null;
        }

        // #9 return average height of customers or 0 if empty

        public float CalculateAverageHeight(List<Customer> customers)
        {
            return 0;
        }

        // #10 return a dictionary of id/"firstName+surname" k/v pairs

        public Dictionary<Guid, string> CustomerDictionary(List<Customer> customers)
        {
            return null;
        }

        // #11 returns a bool - tell us if all customers are over a certain height

        public bool CheckAllCustomersTallEnough(List<Customer> customers, int heightCM)
        {
            return false;
        }

        // #12 returns a list of customers de-duplicated on surname ??? distinct on surname ?? improve description!

        public List<Customer> GetFirstOfEachFamily(List<Customer> customers)
        {
            return null;
        }

        // #13 return customers grouped by surname

        public IDictionary<string, List<Customer>> GroupIntoFamilies(List<Customer> customers)
        {
            return null;
        }

        // #14 return a dictionary of surname / avg height for customers with surname <"Jones", 180cm>

        // #15 hashset - improve description

        // #16 return the Id of the tallest member of each family

        // #17

        public Dictionary<string, int> TwitterFeedAnalysis(IEnumerable<string> twitterFeed)
        {
            return new Dictionary<string, int>();
        }

        // #18

        public List<User> UpdateUserNotes(IEnumerable<User> users, IEnumerable<Note> updatedNotes)
        {
            return new List<User>();
        }

        // #19

        public Dictionary<string, List<string>> CategoriseCustomerIds(List<Customer> customers, List<Guid> currentGuids)
        {
            return new Dictionary<string, List<string>>();
        }

        // #20

        public Artwork[] TriageArtworks(List<Artwork> submissions, DateTime cutoffDate)
        {
            return new Artwork[0];
        }
    }
}
