using System;
using System.Collections.Generic;
using System.Linq;
using Katas.Linq;
using Katas.Models;
using Xunit;

namespace Katas.Test
{
    public class LinqTests : KatasTestBase
    {
        internal LinqKatas _linqKatas = new LinqKatas();

        internal List<Person> BuildPeople(int count)
        {
            var people = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                var person = new Person
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Steve",
                    Surname = "Sharky",
                    HeightCM = 180 + i,
                };
                people.Add(person);
            }

            return people;
        }
    }

    // #1

    public class GetLargestNum : LinqTests
    {
        [Fact]
        public void GivenEmptyList_Returns0()
        {
            // arrange
            var testList = new List<int>();

            // assert
            var result = _linqKatas.GetLargestNum(testList);

            // act
            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenListContainingSingleNumber_ReturnsNumber()
        {
            // arrange
            var testList = new List<int> { 50 };

            // assert
            var result = _linqKatas.GetLargestNum(testList);

            // act
            Assert.Equal(50, result);
        }

        [Fact]
        public void GivenMultipleNumbers_ReturnsLargestNumber()
        {
            // arrange
            var testList = new List<int> { 0, 14, 50, 999 };

            // assert
            var result = _linqKatas.GetLargestNum(testList);

            // act
            Assert.Equal(999, result);
        }
    }

    // #2

    public class GetFirstPerson : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsNull()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.GetFirstPerson(people);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenList_ReturnsFirstPerson()
        {
            // arrange
            var people = BuildPeople(5);

            var firstPerson = people[0];

            firstPerson.Id = Guid.NewGuid();
            firstPerson.FirstName = "Kendrick";
            firstPerson.Surname = "Lamar";
            firstPerson.HeightCM = 168;

            // act
            var result = _linqKatas.GetFirstPerson(people);

            // assert
            Assert.Equal(result.Id, firstPerson.Id);
            Assert.Equal(result.FirstName, firstPerson.FirstName);
            Assert.Equal(result.Surname, firstPerson.Surname);
            Assert.Equal(result.HeightCM, firstPerson.HeightCM);
        }
    }

    // #3

    public class GetFirstPersonOver : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsNull()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.GetFirstPersonOver(people, 0);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenNopeopleOverHeight_ReturnsNull()
        {
            // arrange
            var people = BuildPeople(5);

            // act
            var result = _linqKatas.GetFirstPersonOver(people, 99999);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenMultiplepeopleOverHeight_ReturnsFirst()
        {
            // arrange
            var people = BuildPeople(10);

            people[1].HeightCM = 260;
            people[3].HeightCM = 240;
            people[4].HeightCM = 221;

            // act
            var result = _linqKatas.GetFirstPersonOver(people, 220);

            // assert
            Assert.Equal(result.Id, people[1].Id);
        }
    }

    // #4

    public class GetUniquePersonByFirstName : LinqTests
    {
        private string TargetName = "Freddy";

        [Fact]
        public void GivenEmptyList_ReturnsNull()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.GetPersonByFirstName(people, TargetName);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenMultipleMatchesInList_ReturnsNull()
        {
            // arrange
            var people = BuildPeople(5);

            people[0].FirstName = TargetName;
            people[1].FirstName = TargetName;

            // act
            var result = _linqKatas.GetPersonByFirstName(people, TargetName);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenSingleMatchInList_ReturnsPerson()
        {
            // arrange
            var people = BuildPeople(5);
            var firstPerson = people[0];

            firstPerson.FirstName = TargetName;

            // act
            var result = _linqKatas.GetPersonByFirstName(people, TargetName);

            // assert
            Assert.Equal(result.Id, firstPerson.Id);
            Assert.Equal(result.FirstName, firstPerson.FirstName);
        }
    }

    // #5

    public class CheckIfPersonExists : LinqTests
    {
        private string TargetName = "Freddy";

        [Fact]
        public void GivenEmptyList_ReturnsFalse()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.CheckIfPersonExists(people, TargetName);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void GivenNoMatch_ReturnsFalse()
        {
            // arrange
            var people = BuildPeople(5);

            // act
            var result = _linqKatas.CheckIfPersonExists(people, TargetName);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void GivenMatch_ReturnsTrue()
        {
            // arrange
            var people = BuildPeople(5);

            people[0].FirstName = TargetName;

            // act
            var result = _linqKatas.CheckIfPersonExists(people, TargetName);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenMultipleMatches_ReturnsTrue()
        {
            // arrange
            var people = BuildPeople(5);

            people[0].FirstName = TargetName;
            people[1].FirstName = TargetName;

            // act
            var result = _linqKatas.CheckIfPersonExists(people, TargetName);

            // assert
            Assert.Null(result);
        }
    }

    // #6

    public class GetSurnames : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsEmpty()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.GetSurnames(people);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void Givenpeople_ReturnsSurnames()
        {
            // arrange
            var people = BuildPeople(3);

            people[0].Surname = "Ali";
            people[1].Surname = "Brown";
            people[2].Surname = "Carlson";

            // act
            var result = _linqKatas.GetSurnames(people);

            // assert
            Assert.Equal("Ali", result.ElementAt(0));
            Assert.Equal("Brown", result.ElementAt(1));
            Assert.Equal("Carlson", result.ElementAt(2));
        }
    }

    // #7

    public class GetAllFirstNamesOfFamilyMembers : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsEmpty()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.GetAllFirstNamesOfFamilyMembers(people, "");

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenNoMatches_ReturnsEmpty()
        {
            // arrange
            var people = BuildPeople(10);

            // act
            var result = _linqKatas.GetAllFirstNamesOfFamilyMembers(people, "Martin");

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenMatches_ReturnsFirstNames()
        {
            // arrange
            var people = BuildPeople(5);

            people[0].FirstName = "Sarah";
            people[0].Surname = "Ali";
            people[1].FirstName = "Susan";
            people[1].Surname = "Ali";
            people[2].FirstName = "Shelly";
            people[2].Surname = "Ali";

            // act
            var result = _linqKatas.GetAllFirstNamesOfFamilyMembers(people, "Ali");

            // assert
            Assert.True(result.Count() == 3);
            Assert.Equal("Sarah", result.ElementAt(0));
            Assert.Equal("Susan", result.ElementAt(1));
            Assert.Equal("Shelly", result.ElementAt(2));
        }
    }

    // #8

    public class OrderpeopleByHeight : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsEmpty()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.OrderPeopleByHeight(people);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void Givenpeople_ReturnsOrderedAsc()
        {
            // arrange
            var people = BuildPeople(5);

            people[0].HeightCM = 140;
            people[1].HeightCM = 120;
            people[2].HeightCM = 160;
            people[3].HeightCM = 170;
            people[4].HeightCM = 110;

            // act
            var result = _linqKatas.OrderPeopleByHeight(people);

            // assert
            Assert.True(result.Count() == 5);
            Assert.Equal(people[4].Id, result.ElementAt(0).Id);
            Assert.Equal(people[1].Id, result.ElementAt(1).Id);
            Assert.Equal(people[0].Id, result.ElementAt(2).Id);
            Assert.Equal(people[2].Id, result.ElementAt(3).Id);
            Assert.Equal(people[3].Id, result.ElementAt(4).Id);
        }
    }

    // #9

    public class CalculateAverageHeight : LinqTests
    {
        [Fact]
        public void GivenEmptyList_Returns0()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.CalculateAverageHeight(people);

            // assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenSinglePerson_ReturnsHeight()
        {
            // arrange
            var people = BuildPeople(1);

            people[0].HeightCM = 180;

            // act
            var result = _linqKatas.CalculateAverageHeight(people);

            // assert
            Assert.True(180, result);
        }

        [Fact]
        public void Givenpeople_ReturnsAverage()
        {
            // arrange
            var people = BuildPeople(3);

            people[0].HeightCM = 180;
            people[1].HeightCM = 200;
            people[2].HeightCM = 220;

            // act
            var result = _linqKatas.CalculateAverageHeight(people);

            // assert
            Assert.Equal(200, result);
        }
    }

    // #10

    public class PersonDictionary : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsEmptyDictionary()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.CustomerDictionary(people);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void Givenpeople_ReturnsDictionary()
        {
            // arrange
            var people = BuildPeople(3);

            // act
            var result = _linqKatas.CustomerDictionary(people);

            // assert
            var first = result.ElementAt(0);
            var second = result.ElementAt(1);
            var third = result.ElementAt(2);

            Assert.Equal(first.Key, people[0].Id);
            Assert.Equal(first.Value, people[0].FirstName + people[0].Surname);
            Assert.Equal(second.Key, people[1].Id);
            Assert.Equal(second.Value, people[1].FirstName + people[1].Surname);
            Assert.Equal(third.Key, people[2].Id);
            Assert.Equal(third.Value, people[2].FirstName + people[2].Surname);
        }
    }

    // #11

    public class CheckAllpeopleTallEnough : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsFalse()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.CheckAllPeopleTallEnough(people, 999);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void GivenOneTooShort_ReturnsFalse()
        {
            // arrange
            var people = BuildPeople(10);

            people[0].HeightCM = 100;

            // act
            var result = _linqKatas.CheckAllPeopleTallEnough(people, 101);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void GivenAllTallEnough_ReturnsTrue()
        {
            // arrange
            var people = BuildPeople(10);

            // act
            var result = _linqKatas.CheckAllPeopleTallEnough(people, 101);

            // assert
            Assert.True(result);
        }
    }

    // #12

    public class GetFirstOfEachFamily : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsEmpty()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.GetFirstOfEachFamily(people);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenNoSurnameVariation_ReturnsSinglePerson()
        {
            // arrange
            var people = BuildPeople(5);

            // act
            var result = _linqKatas.GetFirstOfEachFamily(people);

            // assert
            Assert.True(result.Count == 1);
            Assert.Equal(result[0].Id, people[0].Id);
        }

        [Fact]
        public void GivenMultipleSurnames_ReturnsOnePersonPerFamily()
        {
            // arrange
            var people = BuildPeople(6);

            people[2].Surname = "Smith";
            people[3].Surname = "Smith";
            people[4].Surname = "White";
            people[5].Surname = "White";


            // act
            var result = _linqKatas.GetFirstOfEachFamily(people);

            // assert
            Assert.True(result.Count == 3);
            Assert.Equal(result[0].Id, people[0].Id);
            Assert.Equal(result[1].Id, people[2].Id);
            Assert.Equal(result[2].Id, people[4].Id);
        }
    }

    // #13

    public class GetFamilies : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsEmpty()
        {
            // arrange
            var people = new List<Person>();

            // act
            var result = _linqKatas.GroupIntoFamilies(people);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenNoSurnameVariation_ReturnsSingleDictionaryEntry()
        {
            // arrange
            var people = BuildPeople(4);

            // act
            var result = _linqKatas.GroupIntoFamilies(people);

            // assert
            Assert.Single(result);
            Assert.True(result.ElementAt(0).Value.Count == people.Count);
        }

        [Fact]
        public void GivenMultipleSurnames_ReturnsMixedDictionary()
        {
            // arrange
            var people = BuildPeople(6);

            people[3].Surname = "Smith";
            people[4].Surname = "Smith";
            people[5].Surname = "Smith";

            // act
            var result = _linqKatas.GroupIntoFamilies(people);

            // assert
            Assert.True(result.Count() == 2);

            var sharks = result.Where(x => x.Key == "Sharky").First();
            var smiths = result.Where(x => x.Key == "Smith").First();

            Assert.True(sharks.Value.Count == 3);
            foreach (var person in sharks.Value)
            {
                Assert.True(person.Surname == "Sharky");
            }

            Assert.True(smiths.Value.Count == 3);
            foreach (var person in smiths.Value)
            {
                Assert.True(person.Surname == "Smith");
            }
        }
    }
}
