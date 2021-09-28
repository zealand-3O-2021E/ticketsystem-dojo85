using System;
using ClassLibraryTicketSystem;

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// OresundBron specific Car class.
    /// </summary>
    public class OresundCar : Car
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
        public OresundCar(string license, DateTime date, bool brobizz = false)
        {
            LicensePlate = license;
            Date = date;
            HasBrobizz = brobizz;
        }

        public OresundCar()
        {
        }

        /// <summary>
        /// Use this property to specify the ticket price for this vehicle type.
        /// </summary>
        protected override double TicketPrice => 410;

        /// <summary>
        /// Use this method to specify the vehicle type.
        /// </summary>
        public override string VehicleType() => "Oresund Car";

        /// <summary>
        /// This method returns the price including an eventual Brobizz discount.
        /// </summary>
        /// <returns>The final price as double.</returns>
        public override double Price()
        {
            if (HasBrobizz)
            {
                return 161;
            }
            return TicketPrice;
        }
    }
}
