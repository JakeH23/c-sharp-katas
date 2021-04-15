using System;
using System.Collections.Generic;
using Katas.Models;

namespace Katas.Base
{
    public class KatasBase
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
            var destiny = GetDestiny(hero);

            if (destiny == "Druid")
            {
                var druid = new Druid { Name = hero.Name };
                return druid.BattleCry;
            }
            else
            {
                var mage = new Mage { Name = hero.Name };
                return mage.BattleCry;
            }
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

        /////////////////////////////////////////////
        /// Dont touch this method!
        /// It's used in the HeroCareerChange kata!
        ///

        private string GetDestiny(Villager villager)
        {
            return villager.Name.Length % 2 == 0 ? "Druid" : "Mage";
        }
    }
}

