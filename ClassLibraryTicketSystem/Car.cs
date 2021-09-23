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
        /// Use this constructor to specify if a Brobizz was used.
        /// </summary>
        /// <param name="brobizz">Set "true" if a Brobizz is used.
        /// Set "false" or "null" if no Brobizz is used.
        /// </param>
        public Car(bool brobizz)
            :base(brobizz)
        {
            HasBrobizz = brobizz;
        }

        public Car()
        {
        }

        /// <summary>
        /// Use this property to specify the ticket price for this vehicle type.
        /// </summary>
        protected override double TicketPrice => 240;
        /// <summary>
        /// Use this property to specify the vehicle type.
        /// </summary>
        protected override string Type => "Car";
    }
}
