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

        internal List<Customer> BuildCustomers(int count)
        {
            var customers = new List<Customer>();

            for (int i = 0; i < count; i++)
            {
                var customer = new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Steve",
                    Surname = "Sharky",
                    HeightCM = 180 + i,
                };
                customers.Add(customer);
            }

            return customers;
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

    public class GetFirstCustomer : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsNull()
        {
            // arrange
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.GetFirstCustomer(customers);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenList_ReturnsFirstCustomer()
        {
            // arrange
            var customers = BuildCustomers(5);

            var firstCustomer = customers[0];

            firstCustomer.Id = Guid.NewGuid();
            firstCustomer.FirstName = "Kendrick";
            firstCustomer.Surname = "Lamar";
            firstCustomer.HeightCM = 168;

            // act
            var result = _linqKatas.GetFirstCustomer(customers);

            // assert
            Assert.Equal(result.Id, firstCustomer.Id);
            Assert.Equal(result.FirstName, firstCustomer.FirstName);
            Assert.Equal(result.Surname, firstCustomer.Surname);
            Assert.Equal(result.HeightCM, firstCustomer.HeightCM);
        }
    }

    // #3

    public class GetFirstCustomerOver : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsNull()
        {
            // arrange
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.GetFirstCustomerOver(customers, 0);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenNoCustomersOverHeight_ReturnsNull()
        {
            // arrange
            var customers = BuildCustomers(5);

            // act
            var result = _linqKatas.GetFirstCustomerOver(customers, 99999);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenMultipleCustomersOverHeight_ReturnsFirst()
        {
            // arrange
            var customers = BuildCustomers(10);

            customers[1].HeightCM = 260;
            customers[3].HeightCM = 240;
            customers[4].HeightCM = 221;

            // act
            var result = _linqKatas.GetFirstCustomerOver(customers, 220);

            // assert
            Assert.Equal(result.Id, customers[1].Id);
        }
    }

    // #4

    public class GetUniqueCustomerByFirstName : LinqTests
    {
        private string TargetName = "Freddy";

        [Fact]
        public void GivenEmptyList_ReturnsNull()
        {
            // arrange
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.GetUniqueCustomerByFirstName(customers, TargetName);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenMultipleMatchesInList_ReturnsNull()
        {
            // arrange
            var customers = BuildCustomers(5);

            customers[0].FirstName = TargetName;
            customers[1].FirstName = TargetName;

            // act
            var result = _linqKatas.GetUniqueCustomerByFirstName(customers, TargetName);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenSingleMatchInList_ReturnsCustomer()
        {
            // arrange
            var customers = BuildCustomers(5);
            var firstCustomer = customers[0];

            firstCustomer.FirstName = TargetName;

            // act
            var result = _linqKatas.GetUniqueCustomerByFirstName(customers, TargetName);

            // assert
            Assert.Equal(result.Id, firstCustomer.Id);
            Assert.Equal(result.FirstName, firstCustomer.FirstName);
        }
    }

    // #5

    public class CheckIfCustomerExists : LinqTests
    {
        private string TargetName = "Freddy";

        [Fact]
        public void GivenEmptyList_ReturnsFalse()
        {
            // arrange
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.CheckIfCustomerExists(customers, TargetName);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void GivenNoMatch_ReturnsFalse()
        {
            // arrange
            var customers = BuildCustomers(5);

            // act
            var result = _linqKatas.CheckIfCustomerExists(customers, TargetName);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void GivenMatch_ReturnsTrue()
        {
            // arrange
            var customers = BuildCustomers(5);

            customers[0].FirstName = TargetName;

            // act
            var result = _linqKatas.GetUniqueCustomerByFirstName(customers, TargetName);

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GivenMultipleMatches_ReturnsTrue()
        {
            // arrange
            var customers = BuildCustomers(5);

            customers[0].FirstName = TargetName;
            customers[1].FirstName = TargetName;

            // act
            var result = _linqKatas.GetUniqueCustomerByFirstName(customers, TargetName);

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
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.GetSurnames(customers);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenCustomers_ReturnsSurnames()
        {
            // arrange
            var customers = BuildCustomers(3);

            customers[0].Surname = "Ali";
            customers[1].Surname = "Brown";
            customers[2].Surname = "Carlson";

            // act
            var result = _linqKatas.GetSurnames(customers);

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
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.GetAllFirstNamesOfFamilyMembers(customers, "");

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenNoMatches_ReturnsEmpty()
        {
            // arrange
            var customers = BuildCustomers(10);

            // act
            var result = _linqKatas.GetAllFirstNamesOfFamilyMembers(customers, "Martin");

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenMatches_ReturnsFirstNames()
        {
            // arrange
            var customers = BuildCustomers(5);

            customers[0].FirstName = "Sarah";
            customers[0].Surname = "Ali";
            customers[1].FirstName = "Susan";
            customers[1].Surname = "Ali";
            customers[2].FirstName = "Shelly";
            customers[2].Surname = "Ali";

            // act
            var result = _linqKatas.GetAllFirstNamesOfFamilyMembers(customers, "Ali");

            // assert
            Assert.True(result.Count() == 3);
            Assert.Equal("Sarah", result.ElementAt(0));
            Assert.Equal("Susan", result.ElementAt(1));
            Assert.Equal("Shelly", result.ElementAt(2));
        }
    }

    // #8

    public class OrderCustomersByHeight : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsEmpty()
        {
            // arrange
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.OrderCustomersByHeight(customers);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenCustomers_ReturnsOrderedAsc()
        {
            // arrange
            var customers = BuildCustomers(5);

            customers[0].HeightCM = 140;
            customers[1].HeightCM = 120;
            customers[2].HeightCM = 160;
            customers[3].HeightCM = 170;
            customers[4].HeightCM = 110;

            // act
            var result = _linqKatas.OrderCustomersByHeight(customers);

            // assert
            Assert.True(result.Count() == 5);
            Assert.Equal(customers[4].Id, result.ElementAt(0).Id);
            Assert.Equal(customers[1].Id, result.ElementAt(1).Id);
            Assert.Equal(customers[0].Id, result.ElementAt(2).Id);
            Assert.Equal(customers[2].Id, result.ElementAt(3).Id);
            Assert.Equal(customers[3].Id, result.ElementAt(4).Id);
        }
    }

    // #9

    public class CalculateAverageHeight : LinqTests
    {
        [Fact]
        public void GivenEmptyList_Returns0()
        {
            // arrange
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.CalculateAverageHeight(customers);

            // assert
            Assert.True(result == 0);
        }

        [Fact]
        public void GivenSingleCustomer_ReturnsHeight()
        {
            // arrange
            var customers = BuildCustomers(1);

            customers[0].HeightCM = 180;

            // act
            var result = _linqKatas.CalculateAverageHeight(customers);

            // assert
            Assert.True(result == 180);
        }

        [Fact]
        public void GivenCustomers_ReturnsAverage()
        {
            // arrange
            var customers = BuildCustomers(3);

            customers[0].HeightCM = 180;
            customers[0].HeightCM = 200;
            customers[0].HeightCM = 220;

            // act
            var result = _linqKatas.CalculateAverageHeight(customers);

            // assert
            Assert.True(result == 200);
        }
    }

    // #10

    public class CustomerDictionary : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsEmptyDictionary()
        {
            // arrange
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.CustomerDictionary(customers);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenCustomers_ReturnsDictionary()
        {
            // arrange
            var customers = BuildCustomers(3);

            // act
            var result = _linqKatas.CustomerDictionary(customers);

            // assert
            var first = result.ElementAt(0);
            var second = result.ElementAt(1);
            var third = result.ElementAt(2);

            Assert.Equal(first.Key, customers[0].Id);
            Assert.Equal(first.Value, customers[0].FirstName + customers[0].Surname);
            Assert.Equal(second.Key, customers[1].Id);
            Assert.Equal(second.Value, customers[1].FirstName + customers[1].Surname);
            Assert.Equal(third.Key, customers[2].Id);
            Assert.Equal(third.Value, customers[2].FirstName + customers[2].Surname);
        }
    }

    // #11

    public class CheckAllCustomersTallEnough : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsFalse()
        {
            // arrange
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.CheckAllCustomersTallEnough(customers, 999);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void GivenOneTooShort_ReturnsFalse()
        {
            // arrange
            var customers = BuildCustomers(10);

            customers[0].HeightCM = 100;

            // act
            var result = _linqKatas.CheckAllCustomersTallEnough(customers, 101);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void GivenAllTallEnough_ReturnsTrue()
        {
            // arrange
            var customers = BuildCustomers(10);

            // act
            var result = _linqKatas.CheckAllCustomersTallEnough(customers, 101);

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
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.GetFirstOfEachFamily(customers);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenNoSurnameVariation_ReturnsSinglePerson()
        {
            // arrange
            var customers = BuildCustomers(5);

            // act
            var result = _linqKatas.GetFirstOfEachFamily(customers);

            // assert
            Assert.True(result.Count == 1);
            Assert.Equal(result[0].Id, customers[0].Id);
        }

        [Fact]
        public void GivenMultipleSurnames_ReturnsOnePersonPerFamily()
        {
            // arrange
            var customers = BuildCustomers(6);

            customers[2].Surname = "Smith";
            customers[3].Surname = "Smith";
            customers[4].Surname = "White";
            customers[5].Surname = "White";


            // act
            var result = _linqKatas.GetFirstOfEachFamily(customers);

            // assert
            Assert.True(result.Count == 3);
            Assert.Equal(result[0].Id, customers[0].Id);
            Assert.Equal(result[1].Id, customers[2].Id);
            Assert.Equal(result[2].Id, customers[4].Id);
        }
    }

    // #13

    public class GetFamilies : LinqTests
    {
        [Fact]
        public void GivenEmptyList_ReturnsEmpty()
        {
            // arrange
            var customers = new List<Customer>();

            // act
            var result = _linqKatas.GroupIntoFamilies(customers);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void GivenNoSurnameVariation_ReturnsSingleDictionaryEntry()
        {
            // arrange
            var customers = BuildCustomers(4);

            // act
            var result = _linqKatas.GroupIntoFamilies(customers);

            // assert
            Assert.Single(result);
            Assert.True(result.ElementAt(0).Value.Count == customers.Count);
        }

        [Fact]
        public void GivenMultipleSurnames_ReturnsMixedDictionary()
        {
            // arrange
            var customers = BuildCustomers(6);

            customers[3].Surname = "Smith";
            customers[4].Surname = "Smith";
            customers[5].Surname = "Smith";

            // act
            var result = _linqKatas.GroupIntoFamilies(customers);

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
