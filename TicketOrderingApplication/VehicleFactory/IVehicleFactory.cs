using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace TicketOrderingApplication.VehicleFactory
{
    /// <summary>
    /// Use this interface to create concrete vehicle objects, depending on the used company.
    /// Must be implemented in a concrete class, that provides the functionality.
    /// </summary>
    public interface IVehicleFactory
    {
        /// <summary>
        /// Use this method to create the required Car object.
        /// </summary>
        /// <param name="company">Name of the company to buy the ticket for.</param>
        /// <returns>The concrete Car object, e.g. StorebaeltCar or OresundCar etc.</returns>
        Car CreateCar(string company);

        /// <summary>
        /// Use this method to create the required MC object.
        /// </summary>
        /// <param name="company">Name of the company to buy the ticket for.</param>
        /// <returns>The concrete Car object, e.g. OresundMC etc.</returns>
        MC CreateMc(string company);
    }
}
