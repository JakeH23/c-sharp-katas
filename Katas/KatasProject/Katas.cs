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
            var firstNumber = 0;
            var secondNumber = 1;
            var result = 0;

            switch (num)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    for (var i = 2; i <= num; i++)
                    {
                        result = firstNumber + secondNumber;
                        firstNumber = secondNumber;
                        secondNumber = result;
                    }

                    return result;
            }
        }

        /// Strings
        public string PigLatin(string sentence)
        {
            if (string.IsNullOrEmpty(sentence)) return string.Empty;

            var vowels = new List<string> { "a", "e", "i", "o", "u" };

            var splitSentence = sentence.Split(" ");

            for (var i = 0; i < splitSentence.Length; i++)
            {
                if (vowels.Contains(splitSentence[i].Substring(0, 1)))
                {
                    splitSentence[i] = $"{splitSentence[i]}way";
                }
                else
                {
                    var wordWithoutFirstLetter = splitSentence[i].Substring(1, splitSentence[i].Length - 1);
                    splitSentence[i] = $"{wordWithoutFirstLetter}{splitSentence[i].Substring(0, 1)}";

                    for (var j = 0; j < splitSentence[i].Length; j++)
                    {
                        if (!vowels.Contains(splitSentence[i].Substring(0, 1)))
                        {
                            wordWithoutFirstLetter = splitSentence[i].Substring(1, splitSentence[i].Length - 1);
                            splitSentence[i] = $"{wordWithoutFirstLetter}{splitSentence[i].Substring(0, 1)}";
                            continue;
                        }

                        break;
                    }

                    splitSentence[i] += "ay";
                }
            }

            return string.Join(" ", splitSentence);
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

