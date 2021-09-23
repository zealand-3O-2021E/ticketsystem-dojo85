using System;
using ClassLibraryTicketSystem;

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// OresundBron specific Car class.
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
            : base(brobizz)
        {
            HasBrobizz = brobizz;
        }

        public Car()
        {
        }

        /// <summary>
        /// Use this property to specify the ticket price for this vehicle type.
        /// </summary>
        protected override double TicketPrice => 410;
        /// <summary>
        /// Use this property to specify the vehicle type.
        /// </summary>
        protected override string Type => "Oresund Car";

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
