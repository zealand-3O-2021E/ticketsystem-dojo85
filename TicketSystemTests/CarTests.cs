using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketSystemTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Price_Test()
        {
            Car car = new();
            double expected = 240;

            double actual = car.Price();          

            Assert.AreEqual(expected, actual);
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
