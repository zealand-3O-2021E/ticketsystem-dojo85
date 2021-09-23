using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TicketSystemTests
{
    [TestClass]
    public class VehicleClassTest
    {
        [TestMethod]
        public void NumberPlate_InvalidValue_ThrowsException_Test()
        {
            // Arrange
             var mock = new Mock<Vehicle>();
             var vehicle = mock.Object;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => vehicle.LicensePlate = "12345678");
        }
    }
}
