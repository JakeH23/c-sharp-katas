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
            return num1 * num2;
        }

        public int CalculateDivisors(int num)
        {
            var sum = 0;
            for (var i = 1; i < num; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public int Fibonacci(int num)
        {
            //return Fibonacci(num - 1) + Fibonacci(num - 2);
            return 0;
        }

        /// Strings
        public string PigLatin(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return string.Empty;
            }

            var vowels = "aeiou";
            var pigWords = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                var firstLetter = word.Substring(0, 1).ToLower();
                var restOfWord = word.Substring(1, word.Length - 1).ToLower();
                var currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    pigWords.Add(restOfWord + firstLetter + "ay");
                }
                else
                {
                    pigWords.Add(word + "way");
                }
            }
            return string.Join(" ", pigWords);
        }

        /// Iteration
        public int SumArgs(params int[] nums)
        {
            var count = 0;
            foreach (var num in nums)
            {
                count += num;
            }

            return count;
        }

        public List<Agent> CounterSpy(List<Agent> agents)
        {
            var loyalAgents = new List<Agent>();

            foreach (var agent in agents)
            {
                var agentToLower = agent.Name.ToLower();

                if (!agentToLower.Contains("s") && !agentToLower.Contains("p") && !agentToLower.Contains("y"))
                {
                    loyalAgents.Add(agent);
                }
            }

            return loyalAgents;
        }
        public bool? AreCatsDominant(List<Animal> animals)
        {
            var catCount = 0;
            var dogCount = 0;

            foreach (var animal in animals)
            {
                if (animal.GetType() == typeof(Dog))
                {
                    dogCount++;
                }
                else
                {
                    catCount++;
                }
            }

            if (catCount > dogCount)
            {
                return true;
            }
            else if (catCount < dogCount)
            {
                return false;
            }
            else
            {
                return null;
            }
        }

        ////////////////////////
        /// Classes and Types

        public DugTrio EvolvePokemon(Diglett diglett)
        {
            var dugTrioLevelUpValue = diglett.Level + 1;
            return new DugTrio { Level = dugTrioLevelUpValue };
        }

        public string HeroCareerChange(Hero hero)
        {
            var future = GetDestiny(hero);
            return future == "Druid" ? new Druid { Name = hero.Name }.BattleCry : new Mage { Name = hero.Name }.BattleCry;
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

