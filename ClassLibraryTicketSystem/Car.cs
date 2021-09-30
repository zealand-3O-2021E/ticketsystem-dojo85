using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Represents a vehicle of type: Car
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Use this constructor to create a new car.
        /// </summary>
        /// <param name="license">License plate of the used vehicle.
        /// </param>
        /// <param name="date">Date of the trip.
        /// </param>
        /// <param name="brobizz">Set "true" if a Brobizz is used.
        /// Set "false" or "null" if no Brobizz is used.
        /// </param>
        public Car(string license, DateTime date, bool brobizz = false)
            :base(license, date, brobizz)
        {
        }

        public Car()
        {
        }

        /// <summary>
        /// Use this property to specify the ticket price for this vehicle type.
        /// </summary>
        protected override double TicketPrice => 240;

        public override string VehicleType() => "Car";
    }
}
