using System.Collections.Generic;
using Katas.Base;
using Katas.Models;
using Xunit;

namespace Katas.Test
{
    public class KatasTestBase
    {
        internal KatasBase _testClass = new KatasBase();
    }
    public class MultiplyInts : KatasTestBase
    {
        [Fact]
        public void ReturnsMultipleOfTwoNumbers()
        {
            // arrange
            var num1 = 5;
            var num2 = 8;

            // act
            var sum = _testClass.MultiplyNums(num1, num2);

            // assert
            Assert.Equal(40, sum);
        }

        [Fact]
        public void ReturnsMultipleOfNegativeNumbers()
        {
            // arrange
            var num1 = -10;
            var num2 = -3;

            // act
            var sum = _testClass.MultiplyNums(num1, num2);

            // assert
            Assert.Equal(30, sum);
        }
    }
    public class CalculateDivisors : KatasTestBase
    {
        [Fact]
        public void Given0_Returns0()
        {
            // arrange

            // act
            var result = _testClass.CalculateDivisors(0);

            // assert
            Assert.Equal(0, result);

        }

        [Fact]
        public void Given5_Returns3()
        {
            // arrange

            // act
            var result = _testClass.CalculateDivisors(5);

            // assert
            Assert.Equal(3, result);

        }


        [Fact]
        public void Given6_Returns8()
        {
            // arrange

            // act
            var result = _testClass.CalculateDivisors(6);

            // assert
            Assert.Equal(8, result);

        }

        [Fact]
        public void Given12_Returns33()
        {
            // arrange

            // act
            var result = _testClass.CalculateDivisors(12);

            // assert
            Assert.Equal(33, result);

        }
    }
    public class Fibonacci : KatasTestBase
    {
        [Fact]
        public void WhenGiven0_Returns0()
        {
            // arrange
            var input = 0;

            // act
            var result = _testClass.Fibonacci(input);

            // assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void WhenGiven1_Returns1()
        {
            // arrange
            var input = 1;

            // act
            var result = _testClass.Fibonacci(input);

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenGiven4_Returns3()
        {
            // arrange
            var input = 4;

            // act
            var result = _testClass.Fibonacci(input);

            // assert
            Assert.Equal(3, result);
        }


        [Fact]
        public void WhenGiven15_Returns610()
        {
            // arrange
            var input = 15;

            // act
            var result = _testClass.Fibonacci(input);

            // assert
            Assert.Equal(610, result);
        }
    }
    public class PigLatin : KatasTestBase
    {
        [Fact]
        public void GivenEmptyString_ReturnsEmptyString()
        {
            // arrange
            var sentence = "";
            var expected = "";
            // act
            var result = _testClass.PigLatin(sentence);

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenWord_ThatBeginsWithOneConsonant_ReturnsTranslatedWord()
        {
            // arrange
            var sentence = "pogo";
            var expected = "ogopay";

            // act
            var result = _testClass.PigLatin(sentence);

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenWord_ThatBeginsWithTwoConsonants_ReturnsTranslatedWord()
        {
            // arrange
            var sentence = "smile";
            var expected = "ilesmay";

            // act
            var result = _testClass.PigLatin(sentence);

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenWord_ThatBeginsWithAVowel_ReturnsTranslatedWord()
        {
            // arrange
            var sentence = "oblong";
            var expected = "oblongway";

            // act
            var result = _testClass.PigLatin(sentence);

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenSentence_ReturnsTranslatedSentence()
        {
            // arrange
            var sentence = "avocado toast breakfast";
            var expected = "avocadoway oasttay eakfastbray";

            // act
            var result = _testClass.PigLatin(sentence);

            // assert
            Assert.Equal(expected, result);
        }
    }
    public class SumArgs : KatasTestBase
    {
        [Fact]
        public void Returns0_WhenPassedNoArgs()
        {
            // arrange

            // act
            var sum = _testClass.SumArgs();

            // assert
            Assert.Equal(0, sum);
        }

        [Fact]
        public void ReturnsSum_WhenPassedTwoArgs()
        {
            // arrange
            var num1 = 5;
            var num2 = 10;

            // act
            var sum = _testClass.SumArgs(num1, num2);

            // assert
            Assert.Equal(15, sum);
        }

        [Fact]
        public void ReturnsSum_WhenPassedMultipleArgs()
        {
            // arrange
            var num1 = 5;
            var num2 = 10;
            var num3 = 15;
            var num4 = 20;

            // act
            var sum = _testClass.SumArgs(num1, num2, num3, num4);

            // assert
            Assert.Equal(50, sum);
        }
    }
    public class CounterSpy : KatasTestBase
    {
        [Fact]
        public void GivenNoAgents_ReturnsEmptyList()
        {
            // arrange
            var agents = new List<Agent> { };

            // act
            var loyalAgents = _testClass.CounterSpy(agents);

            // assert
            Assert.Empty(loyalAgents);
        }

        [Fact]
        public void GivenLoyalAgents_ReturnsLoyalAgents()
        {
            // arrange
            var loyalAgent = new Agent() { Name = "Doug Hellowell" };
            var agents = new List<Agent> {
                loyalAgent
            };

            // act
            var loyalAgents = _testClass.CounterSpy(agents);

            // assert
            Assert.Equal(agents, loyalAgents);
        }

        [Fact]
        public void GivenASpy_ReturnsEmptyList()
        {
            // arrange
            var spy = new Agent() { Name = "Suspicious Bob" };
            var agents = new List<Agent> {
                spy
            };

            // act
            var loyalAgents = _testClass.CounterSpy(agents);

            // assert
            Assert.Empty(loyalAgents);
        }

        [Fact]
        public void GivenAgentsOfVaryingLoyalty_ReturnsFilteredList()
        {
            // arrange
            var loyalAgent1 = new Agent() { Name = "Doug Hellowell" };
            var loyalAgent2 = new Agent() { Name = "Bruce Agent" };
            var spy1 = new Agent() { Name = "Suspicious Bob" };
            var spy2 = new Agent() { Name = "Tom Kiggins" };

            var agents = new List<Agent> {
                loyalAgent1, spy1, spy2, loyalAgent2
            };

            var expected = new List<Agent>
            {
                loyalAgent1, loyalAgent2
            };

            // act
            var loyalAgents = _testClass.CounterSpy(agents);

            // assert
            Assert.Equal(expected, loyalAgents);
        }
    }
    public class AreCatsDominant : KatasTestBase
    {
        [Fact]
        public void GivenNoAnimals_ReturnsNull()
        {
            // arrange
            var animals = new List<Animal>();

            // act
            var result = _testClass.AreCatsDominant(animals);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenOnlyCats_ReturnsTrue()
        {
            // arrange
            var animals = new List<Animal> { new Cat() };

            // act
            var result = _testClass.AreCatsDominant(animals);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void GivenOnlyDogs_ReturnsFalse()
        {
            // arrange
            var animals = new List<Animal> { new Dog() };

            // act
            var result = _testClass.AreCatsDominant(animals);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void GivenMixedInput_ReturnsExpectedValue()
        {
            // arrange
            var animals1 = new List<Animal> { new Dog(), new Cat(), new Cat() };
            var animals2 = new List<Animal> { new Dog(), new Dog(), new Cat() };
            var animals3 = new List<Animal> { new Dog(), new Dog(), new Cat(), new Cat() };

            // act
            var result1 = _testClass.AreCatsDominant(animals1);
            var result2 = _testClass.AreCatsDominant(animals2);
            var result3 = _testClass.AreCatsDominant(animals3);

            // assert
            Assert.True(result1);
            Assert.False(result2);
            Assert.Null(result3);
        }
    }
    public class EvolvePokemon : KatasTestBase
    {
        [Fact]
        public void GivenDiglett_ReturnsDugtrio()
        {
            // arrange
            var testDiglett = new Diglett { Level = 25 };
            var testDiglett2 = new Diglett { Level = 30 };

            // act
            var evolvedPokemon = _testClass.EvolvePokemon(testDiglett);
            var evolvedPokemon2 = _testClass.EvolvePokemon(testDiglett2);

            // assert
            Assert.Equal(26, evolvedPokemon.Level);
            Assert.Equal(31, evolvedPokemon2.Level);
        }
    }
    public class HeroCareerChange : KatasTestBase
    {
        [Fact]
        public void GivenVillagerWithOddNumberedName_ReturnsMageBattleCry()
        {
            // arrange
            var testHero = new Hero { Name = "Eve" };
            var expected = "I am Eve and I cast Fireball!";

            // act
            var shout = _testClass.HeroCareerChange(testHero);

            // assert
            Assert.Equal(expected, shout);
        }

        [Fact]
        public void GivenVillagerWithEvenNumberedName_ReturnsDruidBattleCry()
        {
            // arrange
            var testHero = new Hero { Name = "Doug" };
            var expected = "I, Doug, call upon the forces of nature!";

            // act
            var shout = _testClass.HeroCareerChange(testHero);

            // assert
            Assert.Equal(expected, shout);
        }
    }
}
