using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Represents a vehicle of type: Car
    /// </summary>
    public class MC
    {
        /// <summary>
        /// The license number plate of the vehicle used.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// The date and time of the ticket purchase with this vehicle.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Method to retrieve the ticket price for this vehicle.
        /// </summary>
        /// <returns>Price as double</returns>
        public double Price()
        {
            return 125;
        }
        
        /// <summary>
        /// Method to retrieve the vehicle type.
        /// </summary>
        /// <returns>Vehicle type as string.</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}
