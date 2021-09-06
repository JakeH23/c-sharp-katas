using System;
using System.Collections.Generic;
using Katas.Models;
using KatasProject;
using Xunit;

namespace Katas.Tdd.Test
{
    public class TDDTest
    {
        internal TDDBase _testClass = new TDDBase();
        internal DateTime _time = DateTime.UtcNow;
    }

    public class CheckHeight : TDDTest
    {
        [Fact]
        public void GivenNoPerson_ReturnFalse()
        {
            // arrange

            // act
            var res = _testClass.CheckHeight(null);

            // assert
            Assert.False(res);
        }

        [Fact]
        public void GivenPerson_ReturnFalseIfUnderGivenHeight()
        {
            // arrange
            var person = new Person
            {
                FirstName = "Jake",
                Surname = "Heaney",
                HeightCM = 154,
                Id = Guid.NewGuid()
            };

            // act
            var res = _testClass.CheckHeight(person);

            // assert
            Assert.False(res);
        }

        [Fact]
        public void GivenPerson_ReturnFalseIfSameAsGivenHeight()
        {
            // arrange
            var person = new Person
            {
                FirstName = "Jake",
                Surname = "Heaney",
                HeightCM = 155,
                Id = Guid.NewGuid()
            };

            // act
            var res = _testClass.CheckHeight(person);

            // assert
            Assert.False(res);
        }

        [Fact]
        public void GivenPerson_ReturnTrueIfOverGivenHeight()
        {
            // arrange
            var person = new Person
            {
                FirstName = "Jake",
                Surname = "Heaney",
                HeightCM = 156,
                Id = Guid.NewGuid()
            };

            // act
            var res = _testClass.CheckHeight(person);

            // assert
            Assert.True(res);
        }
    }

    public class ConvertToSassCase : TDDTest
    {
        [Fact]
        public void GivenEmptyString_ReturnEmptyString()
        {
            // arrange
            var input = "";

            // act
            var res = _testClass.ConvertToSassCase(input);

            // assert
            Assert.Equal("", res);
        }

        [Theory]
        //arrange
        [InlineData("a")]
        [InlineData("A")]
        public void GivenSingleChar_ReturnUpperCaseChar(string input)
        {
            // act
            var res = _testClass.ConvertToSassCase(input);

            // assert
            Assert.Equal(input.ToUpper(), res);
        }

        [Theory]
        //arrange
        [InlineData("aNaNaNa", "AnAnAnA")]
        [InlineData("AnAnAna", "AnAnAnA")]
        [InlineData("aaaaaaa", "AaAaAaA")]
        [InlineData("AAAAAAA", "AaAaAaA")]
        public void GivenMultipleChar_ReturnSassCaseStringStartingUpperCase(string input, string expected)
        {
            // act
            var res = _testClass.ConvertToSassCase(input);

            // assert
            Assert.Equal(expected, res);
            Assert.Equal("A", res[0].ToString());
        }
    }

    public class TriageArtworks : TDDTest
    {
        [Fact]
        public void GivenAnEmptyList_ReturnEmptyList()
        {
            // arrange
            var cutOffDate = _time.AddDays(-1);
            var input = new List<Artwork>();

            // act
            var res = _testClass.TriageArtworks(input, cutOffDate);

            // assert
            Assert.Empty(res);
        }

        [Fact]
        public void GivenAnListOf3_ReturnAll3Artworks()
        {
            // arrange
            var cutOffDate = _time.AddDays(-1);

            var input = new List<Artwork>
            {
                new Artwork
                {
                    Artist = "Bob",
                    Desctiption = "pretty picture",
                    submissionTimestamp = _time.AddDays(-2)
                },
                new Artwork
                {
                    Artist = "Pablo",
                    Desctiption = "abstract picture",
                    submissionTimestamp = _time.AddDays(-52)
                },
                new Artwork
                {
                    Artist = "Claude",
                    Desctiption = "modernism thing",
                    submissionTimestamp = _time.AddDays(-64)
                }
            };

            // act
            var res = _testClass.TriageArtworks(input, cutOffDate);

            // assert
            Assert.Equal(3, res.Count);
        }

        [Fact]
        public void GivenAnListOf3_ReturnEmptyListIfAllLateOnSubmission()
        {
            // arrange
            var cutOffDate = _time.AddDays(-65);

            var input = new List<Artwork>
            {
                new Artwork
                {
                    Artist = "Bob",
                    Desctiption = "pretty picture",
                    submissionTimestamp = _time.AddDays(-2)
                },
                new Artwork
                {
                    Artist = "Pablo",
                    Desctiption = "abstract picture",
                    submissionTimestamp = _time.AddDays(-52)
                },
                new Artwork
                {
                    Artist = "Claude",
                    Desctiption = "modernism thing",
                    submissionTimestamp = _time.AddDays(-64)
                }
            };

            // act
            var res = _testClass.TriageArtworks(input, cutOffDate);

            // assert
            Assert.Empty(res);
        }

        [Fact]
        public void GivenLargeList_ReturnOnly3OfThoseSubmittedBeforeCutOff()
        {
            // arrange
            var cutOffDate = _time.AddDays(-35);

            var input = new List<Artwork>
            {
                new Artwork
                {
                    Artist = "Bob",
                    Desctiption = "pretty picture",
                    submissionTimestamp = _time.AddDays(-2)
                },
                new Artwork
                {
                    Artist = "Pablo",
                    Desctiption = "abstract picture",
                    submissionTimestamp = _time.AddDays(-52)
                },
                new Artwork
                {
                    Artist = "Claude",
                    Desctiption = "modernism thing",
                    submissionTimestamp = _time.AddDays(-64)
                },
                new Artwork
                {
                    Artist = "David",
                    Desctiption = "crazy farm drawing",
                    submissionTimestamp = _time.AddDays(-37)
                },
                new Artwork
                {
                    Artist = "Charles",
                    Desctiption = "boring still life",
                    submissionTimestamp = _time.AddDays(-14)
                },
                new Artwork
                {
                    Artist = "Tracey",
                    Desctiption = "toilet contraption",
                    submissionTimestamp = _time.AddDays(-49)
                }
            };

            // act
            var res = _testClass.TriageArtworks(input, cutOffDate);

            // assert
            Assert.Equal(3, res.Count);
            Assert.Equal("Claude", res[0].Artist);
            Assert.Equal("Pablo", res[1].Artist);
            Assert.Equal("Tracey", res[2].Artist);
        }

        [Fact]
        public void GivenLargeList_ReturnOnlyThoseSubmittedBeforeCutOff()
        {
            // arrange
            var cutOffDate = _time.AddDays(-50);

            var input = new List<Artwork>
            {
                new Artwork
                {
                    Artist = "Bob",
                    Desctiption = "pretty picture",
                    submissionTimestamp = _time.AddDays(-2)
                },
                new Artwork
                {
                    Artist = "Pablo",
                    Desctiption = "abstract picture",
                    submissionTimestamp = _time.AddDays(-52)
                },
                new Artwork
                {
                    Artist = "Claude",
                    Desctiption = "modernism thing",
                    submissionTimestamp = _time.AddDays(-64)
                },
                new Artwork
                {
                    Artist = "David",
                    Desctiption = "crazy farm drawing",
                    submissionTimestamp = _time.AddDays(-37)
                },
                new Artwork
                {
                    Artist = "Charles",
                    Desctiption = "boring still life",
                    submissionTimestamp = _time.AddDays(-14)
                },
                new Artwork
                {
                    Artist = "Tracey",
                    Desctiption = "toilet contraption",
                    submissionTimestamp = _time.AddDays(-49)
                }
            };

            // act
            var res = _testClass.TriageArtworks(input, cutOffDate);

            // assert
            Assert.Equal(2, res.Count);
            Assert.Equal("Claude", res[0].Artist);
            Assert.Equal("Pablo", res[1].Artist);
        }
    }
}