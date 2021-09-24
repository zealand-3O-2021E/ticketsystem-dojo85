using System;
using ClassLibraryTicketSystem;
using CustomerLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using OresundBronTicketLibrary;
using MC = ClassLibraryTicketSystem.MC;

namespace CustomerLibraryTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var customer = GetCustomerTestData();

            double actualTotal = customer.SumForAllTrips();

            Assert.AreEqual(568.75, actualTotal);
        }

        private Customer GetCustomerTestData()
        {
            Customer customer = new Customer();

            StoreBaeltTicketLibrary.Car sc1 = new StoreBaeltTicketLibrary.Car("12345", DateTime.Now);
            MC mc1 = new MC("123", DateTime.Now, true);
            OresundBronTicketLibrary.MC omc1 = new OresundBronTicketLibrary.MC("1324", DateTime.Now);
            // total amount: 568.75

            customer.Trips.Add(sc1);
            customer.Trips.Add(mc1);
            customer.Trips.Add(omc1);
            
            return customer;
        }
    }
}
