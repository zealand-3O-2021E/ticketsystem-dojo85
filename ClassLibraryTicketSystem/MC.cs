using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Represents a vehicle of type: Motorcycle
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Use this constructor to specify if a Brobizz was used.
        /// </summary>
        /// <param name="brobizz">Set "true" if a Brobizz is used.
        /// Set "false" or "null" if no Brobizz is used.
        /// </param>
        public MC(bool brobizz)
            : base(brobizz)
        {
            HasBrobizz = brobizz;
        }

        public MC()
        {
        }

        /// <summary>
        /// Use this property to specify the ticket price for this vehicle type.
        /// </summary>
        protected override double TicketPrice => 125;

        /// <summary>
        /// Use this property to specify the vehicle type.
        /// </summary>
        protected override string Type => "MC";
    }
}
