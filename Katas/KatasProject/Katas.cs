using System;
using System.Collections.Generic;
using Katas.Models;

namespace Katas.Base
{
    public class KatasBase
    {
        /// Numbers

        public int MultiplyNums(int num1, int num2)
        {
            return 0;
        }

        public int CalculateDivisors(int num)
        {
            return 0;
        }

        public int Fibonacci(int num)
        {
            return 0;
        }

        /// Strings
        public string PigLatin(string sentence)
        {
            return "";
        }

        public string ConvertToSassCase(string input)
        {
            return "";
        }

        /// Iteration
        public int SumArgs(params int[] nums)
        {
            return 0;
        }
        public List<Agent> CounterSpy(List<Agent> agents)
        {
            return new List<Agent> { };
        }
        public bool? AreCatsDominant(List<Animal> animals)
        {
            return true;
        }

        ////////////////////////
        /// Classes and Types

        public DugTrio EvolvePokemon(Diglett diglett)
        {
            return null;
        }

        public string HeroCareerChange(Hero hero)
        {
            return null;
        }

        
        /////////////////////////////////////////////
        /// Dont touch this method!
        /// It's used in the HeroCareerChange kata!

        private string GetDestiny(Villager villager)
        {
            return villager.Name.Length % 2 == 0 ? "Druid" : "Mage";
        }
    }
}

