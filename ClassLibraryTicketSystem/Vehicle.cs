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

        #region Constructors
        /// <summary>
        /// Use this constructor to create a new vehicle.
        /// </summary>
        /// <param name="license">License plate of the used vehicle.
        /// </param>
        /// <param name="date">Date of the trip.
        /// </param>
        /// <param name="brobizz">Set "true" if a Brobizz is used.
        /// Set "false" or "null" if no Brobizz is used.
        /// </param>
        public Vehicle(string license, DateTime date, bool brobizz = false)
        {
            LicensePlate = license;
            Date = date;
            HasBrobizz = brobizz;
        }

        public Vehicle()
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// This property indicates if a Brobizz was used to buy the ticket.
        /// </summary>
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
        #endregion

        #region Methods
        /// <summary>
        /// Method to retrieve the ticket price for this vehicle.
        /// If a Brobizz was used, the discount will be included in the returned value.
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
        #endregion
    }
}
