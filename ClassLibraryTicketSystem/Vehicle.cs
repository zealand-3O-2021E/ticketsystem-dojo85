using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
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
        /// This property provides the standard ticket price for this vehicle type.
        /// </summary>
        protected virtual double TicketPrice { get; set; }
        /// <summary>
        /// This property provides the vehicle type.
        /// </summary>
        protected virtual string Type { get; set; }

        /// <summary>
        /// Method to retrieve the ticket price for this vehicle.
        /// </summary>
        /// <returns>Price as double</returns>
        public virtual double Price()
        {
            return TicketPrice;
        }

        /// <summary>
        /// Method to retrieve the vehicle type.
        /// </summary>
        /// <returns>Vehicle type as string.</returns>
        public virtual string VehicleType()
        {
            return Type;
        }


    }
}
