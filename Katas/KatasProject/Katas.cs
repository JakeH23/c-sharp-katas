using System;
using System.Collections.Generic;
using System.Linq;
using Katas.Models;

namespace Katas
{
    public class KatasClass
    {
        ///////////////
        /// Numbers

        public int MultiplyNums(int num1, int num2)
        {
            return 0;
        }

     

        public int SumArgs(params int[] nums)
        {
            return 0;
        }

        public int Fibonacci(int num)
        {
            return 0;
        }

        public int CalculateDivisors(int num)
        {
            return 0;
        }

        ////////////////////////
        /// Classes and Types

        public DugTrio EvolvePokemon(Diglett diglett)
        {
            return null;
        }


        public List<Agent> CounterSpy(List<Agent> agents)
        {
            return new List<Agent> { };
        }


        public string HeroCareerChange(Hero hero)
        {
            return "";
        }

        public bool? AreCatsDominant(List<Animal> animals)
        {
            return true;
        }

        ///////////////
        /// Strings

        public string PigLatin(string sentence)
        {
            return "";
        }

        public string ConvertToSassCase(string input)
        {
            return "";
        }

        ////////////////////////////////
        /// LINQ

        public int GetLargestNum(List<int> nums)
        {
            return 0;
        }

        public List<Customer> CheckHeight(List<Customer> customers)
        {
            return new List<Customer>();
        }

        public Dictionary<string, int> TwitterFeedAnalysis(IEnumerable<string> twitterFeed)
        {
            return new Dictionary<string, int>();
        }

        public List<User> UpdateUserNotes(IEnumerable<User> users, IEnumerable<Note> updatedNotes)
        {
            return new List<User>();
        }

        public Dictionary<string, List<string>> CategoriseCustomerIds(List<Customer> customers, List<Guid> currentGuids)
        {
            return new Dictionary<string, List<string>>();
        }

        public Artwork[] TriageArtworks(List<Artwork> submissions, DateTime cutoffDate)
        {
            return new Artwork[0];
        }

        /////////////////////////////////////////////
        /// Dont touch this method!
        /// It's used in the HeroCareerChange kata!
        ///

        private string GetDestiny(Villager villager)
        {
            return villager.Name.Length % 2 == 0 ? "Mage" : "Druid";
        }
    }
}

