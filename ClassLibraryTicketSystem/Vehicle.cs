using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// This class is used as base class for different vehicle types.
    /// </summary>
    public abstract class Vehicle
    {
        private string _licensePlate;

        public Vehicle(bool brobizz)
        {
            HasBrobizz = brobizz;
        }

        public Vehicle()
        {
                
        }

        protected bool HasBrobizz { get; set; }

        /// <summary>
        /// The license number plate of the vehicle used.
        /// Maximum allowed length of 7 characters.
        /// Throws ArgumentException if longer than 7 characters.
        /// </summary>
        public string LicensePlate {
            get => _licensePlate;
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("The numberplate must not be longer than 7 characters.");
                _licensePlate = value;
            }
        }

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
            if (HasBrobizz)
            {
                return TicketPrice - TicketPrice * 0.05;
            }
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
