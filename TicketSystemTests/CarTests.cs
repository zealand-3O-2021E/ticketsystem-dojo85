using System;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketSystemTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Price_WithDefaultConstructor_Test()
        {
            Car car = new();
            double expected = 240;

            double actual = car.Price();          

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 240)]
        [DataRow(false, 240)]
        [DataRow(true, 228)]
        public void Price_WithBrobizzConstructor_Test(bool hasBrobizz, double expectedPrice)
        {
            Car car = new("12345", DateTime.Now, hasBrobizz);

            double actual = car.Price();

            Assert.AreEqual(expectedPrice, actual, 0.01);
        }

        [TestMethod]
        public void VehicleType_Test()
        {
            Car car = new();
            string expected = "Car";

            string actual = car.VehicleType();

            Assert.AreEqual(expected, actual);
        }
    }
}
