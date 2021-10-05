using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Represents a vehicle of type: Motorcycle
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Use this constructor to create a new motorcycle.
        /// </summary>
        /// <param name="license">License plate of the used vehicle.
        /// </param>
        /// <param name="date">Date of the trip.
        /// </param>
        /// <param name="brobizz">Set "true" if a Brobizz is used.
        /// Set "false" or "null" if no Brobizz is used.
        /// </param>
        public MC(string license, DateTime date, bool brobizz = false)
            : base(license, date, brobizz)
        {
        }

        public MC()
        {
        }

        /// <summary>
        /// Use this property to specify the ticket price for this vehicle type.
        /// </summary>
        protected override double TicketPrice => 125;

        public override string VehicleType() => "MC";
    }
}
