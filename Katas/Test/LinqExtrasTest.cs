using System;
using System.Collections.Generic;
using System.Linq;
using Katas.Models;
using Xunit;

namespace Katas.LinqExtras.Test
{
    public class LinqExtrasTest
    {
        internal Linq.LinqExtras _linqExtras = new Linq.LinqExtras();

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

    //Return a single string made up of the first character of each first name + surname.
    public class BuildStringFromInitials : LinqExtrasTest
    {
        [Fact]
        public void GivenNoPeople_ReturnEmptyString()
        {
            // arrange
            var people = BuildPeople(0);

            // act
            var result = _linqExtras.BuildStringFromInitials(people);

            // assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void GivenSinglePerson_ReturnStringOfInitials()
        {
            // arrange
            var people = BuildPeople(1);

            people[0].FirstName = "Ali";
            people[0].Surname = "Domingo";

            // act
            var result = _linqExtras.BuildStringFromInitials(people);

            // assert
            Assert.Equal(2, result.Length);
            Assert.Equal("A", result.Substring(0, 1));
            Assert.Equal("D", result.Substring(1, 1));
        }

        [Fact]
        public void GivenPeople_ReturnStringOfInitials()
        {
            // arrange
            var people = BuildPeople(2);

            people[0].FirstName = "Ali";
            people[0].Surname = "Carlson";
            people[1].FirstName = "Bob";
            people[1].Surname = "Domingo";

            // act
            var result = _linqExtras.BuildStringFromInitials(people);

            // assert
            Assert.Equal("A", result.Substring(0, 1));
            Assert.Equal("C", result.Substring(1, 1));
            Assert.Equal("B", result.Substring(2, 1));
        }
    }

    //Return a dictionary of surname + avg height of all people with that surname.
    public class AverageHeights : LinqExtrasTest
    {
        [Fact]
        public void GivenNoPeople_ReturnsEmptyDictionary()
        {
            // arrange
            var people = BuildPeople(0);

            // act
            var result = _linqExtras.AverageHeights(people);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenSinglePerson_ReturnTheirHeight()
        {
            // arrange
            var people = BuildPeople(1);

            // act
            var result = _linqExtras.AverageHeights(people);

            // assert
            var nameGroup = result.ElementAt(0);

            Assert.Equal(people[0].Surname, nameGroup.Key);
            Assert.Equal(people[0].HeightCM, nameGroup.Value);
        }

        [Fact]
        public void GivenPeopleWithSameSurname_ReturnSingleResultWithAverageHeight()
        {
            // arrange
            var people = BuildPeople(2);

            people[0].HeightCM = 180;
            people[1].HeightCM = 200;

            // act
            var result = _linqExtras.AverageHeights(people);

            // assert
            var nameGroup = result.ElementAt(0);

            Assert.Equal(people[0].Surname, nameGroup.Key);
            Assert.Equal(190, nameGroup.Value);
        }

        [Fact]
        public void GivenPeopleWithDifferentSurnames_ReturnMultipleKeysInDictionaryWithAverageHeights()
        {
            // arrange
            var people = BuildPeople(2);

            people[0].Surname = "Heaney";
            people[0].HeightCM = 180;

            // act
            var result = _linqExtras.AverageHeights(people);

            // assert
            var nameGroup = result.ElementAt(0);
            var nameGroup2 = result.ElementAt(1);

            Assert.Equal(people[0].Surname, nameGroup.Key);
            Assert.Equal(people[1].Surname, nameGroup2.Key);
            Assert.Equal(people[0].HeightCM, nameGroup.Value);
            Assert.Equal(people[1].HeightCM, nameGroup2.Value);
        }
    }

    //Return the ids of the tallest member of each family.
    public class TallestFamilyMembers : LinqExtrasTest
    {
        [Fact]
        public void GivenNoPeople_ReturnsEmptyList()
        {
            // arrange
            var people = BuildPeople(0);

            // act
            var result = _linqExtras.TallestFamilyMembers(people);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenSinglePerson_ReturnTheirIdInAList()
        {
            // arrange
            var people = BuildPeople(1);

            // act
            var result = _linqExtras.TallestFamilyMembers(people);

            // assert
            Assert.Single(result.ToList());
            Assert.Equal(people[0].Id, result.ToList()[0]);
        }

        [Fact]
        public void GivenPeopleWithSameSurname_ReturnSingleResultWithTallestId()
        {
            // arrange
            var people = BuildPeople(2);

            people[0].HeightCM = 180;
            people[1].HeightCM = 200;

            // act
            var result = _linqExtras.TallestFamilyMembers(people);

            // assert
            Assert.Single(result.ToList());
            Assert.Equal(people[1].Id, result.ToList()[0]);
        }

        [Fact]
        public void GivenPeopleWithDifferentSurnames_ReturnMultipleIdsInListOfTallestMember()
        {
            // arrange
            var people = BuildPeople(3);

            people[0].Surname = "Heaney";
            people[0].HeightCM = 180;
            people[1].HeightCM = 200;
            people[2].HeightCM = 220;

            // act
            var result = _linqExtras.TallestFamilyMembers(people);
            // assert
            Assert.Equal(2, result.ToList().Count);
            Assert.Contains(people[2].Id, result.ToList());
        }
    }

    //Return the most common surname in the list. If there's a draw between two surnames, return the surname that has the most characters in all of the first names.
    public class DominantFamily : LinqExtrasTest
    {
        [Fact]
        public void GivenNoPeople_ReturnEmptyString()
        {
            // arrange
            var people = BuildPeople(0);

            // act
            var result = _linqExtras.DominantFamily(people);

            // assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void GivenSinglePerson_ReturnTheirSurname()
        {
            // arrange
            var people = BuildPeople(1);

            // act
            var result = _linqExtras.DominantFamily(people);

            // assert
            Assert.Equal("Sharky", result);
        }

        [Fact]
        public void GivenMultiplePeopleWithSameSurname_ReturnTheirSurname()
        {
            // arrange
            var people = BuildPeople(2);

            people[1].FirstName = "Ali";

            // act
            var result = _linqExtras.DominantFamily(people);

            // assert
            Assert.Equal("Sharky", result);
        }

        [Fact]
        public void GivenMultiplePeopleWithDifferentSurnames_ReturnTheMostCommonSurname()
        {
            // arrange
            var people = BuildPeople(3);

            people[1].FirstName = "Ali";
            people[1].Surname = "Smith";
            people[2].FirstName = "Bob";
            people[2].Surname = "Smith";

            // act
            var result = _linqExtras.DominantFamily(people);

            // assert
            Assert.Equal("Smith", result);
        }

        [Fact]
        public void GivenEqualNumberOfPeopleWithDifferentSurname_ReturnTheSurnameThatHasTheMostCharactersInAllFirstNames()
        {
            // arrange
            var people = BuildPeople(4);

            people[0].Surname = "Smith";
            people[1].Surname = "Smith";
            people[2].Surname = "Heaney";
            people[3].Surname = "Heaney";
            people[0].FirstName = "Jake";
            people[1].FirstName = "Henry";
            people[2].FirstName = "William";
            people[3].FirstName = "Tom";

            // act
            var result = _linqExtras.DominantFamily(people);

            // assert
            Assert.Equal("Heaney", result);
        }
    }
}
