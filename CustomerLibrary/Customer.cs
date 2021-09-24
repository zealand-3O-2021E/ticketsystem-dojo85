using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibraryTicketSystem;

namespace CustomerLibrary
{
    /// <summary>
    /// Class for customer data.
    /// </summary>
    public class Customer
    {
        public string Name { get; set; }
        public List<Vehicle> Trips { get; set; }

        public Customer()
        {
            Trips = new List<Vehicle>();
        }

        /// <summary>
        /// This method calculates the total amount of money for all tickets the customer bought.
        /// </summary>
        /// <returns>The total amount as double.</returns>
        public double SumForAllTrips()
        {
            return Trips.Sum(t => t.Price());
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
