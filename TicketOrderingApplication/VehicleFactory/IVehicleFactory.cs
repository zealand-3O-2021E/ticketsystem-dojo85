using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace TicketOrderingApplication.VehicleFactory
{
    public interface IVehicleFactory
    {
        Car CreateCar(string company);
        MC CreateMc(string company);
    }
}
