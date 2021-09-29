using System;
using TicketOrderingApplication.VehicleFactory;

namespace TicketOrderingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory factory = new VehicleFactoryV2();
            TicketStore manager = new TicketStore(factory);
            manager.MainMenuLoop();
        }
    }
}
