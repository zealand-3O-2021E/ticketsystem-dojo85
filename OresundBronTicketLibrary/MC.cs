using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// OresundBron specific Motorcycle class.
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
        protected override double TicketPrice => 210;

        /// <summary>
        /// Use this property to specify the vehicle type.
        /// </summary>
        protected override string Type => "Oresund MC";

        /// <summary>
        /// This method returns the price including an eventual Brobizz discount.
        /// </summary>
        /// <returns>The final price as double.</returns>
        public override double Price()
        {
            if (HasBrobizz)
            {
                return 73;
            }
            return TicketPrice;
        }
    }
}
