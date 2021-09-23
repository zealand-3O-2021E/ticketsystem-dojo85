using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;

namespace StorebaeltLibraryTests
{
    [TestClass]
    public class CarClassTests
    {
        [TestMethod]
        [DynamicData(nameof(GetDynamicTestData), DynamicDataSourceType.Method)]
        public void Price_Test(Car car, double expected)
        {
            double actual = car.Price();

            Assert.AreEqual(expected, actual, 0.01);
        }

        private static IEnumerable<object[]> GetDynamicTestData()
        {
            //Monday, without Brobizz
            yield return new object[] { new Car("12345", new DateTime(2021, 09, 13)), 240.00 };
            //Friday, with Brobizz
            yield return new object[] { new Car("12345", new DateTime(2021, 09, 17), true), 228.00 };
            //Saturday and Sunday, without Brobizz
            yield return new object[] { new Car("12345", new DateTime(2021, 09, 18)), 192.00 };
            yield return new object[] { new Car() { Date = new DateTime(2021, 09, 19) }, 192.00 };
            //Saturday and Sunday, with Brobizz
            yield return new object[] { new Car("12345", new DateTime(2021, 09, 18), true), 182.40 };
            yield return new object[] { new Car("12345", new DateTime(2021, 09, 19), true), 182.40 };
        }
    }
}
