using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;
using OresundBronTicketLibrary;
using StoreBaeltTicketLibrary;

namespace TicketOrderingApplication.VehicleFactory
{
    public class VehicleFactoryV2 : IVehicleFactory
    {
        public Car CreateCar(string company)
        {
            Car car = null;
            switch (company)
            {
                case "Storebaelt":
                    car = new StorebaeltCar();
                    break;
                case "Oresund":
                    car = new OresundCar();
                    break;
                default:
                    car = new Car();
                    break;
            }

            return car;
        }

        public MC CreateMc(string company)
        {
            MC mc = null;
            switch (company)
            {
                case "Storebaelt":
                    mc = new MC();
                    break;
                case "Oresund":
                    mc = new OresundMC();
                    break;
                default:
                    mc = new MC();
                    break;
            }

            return mc;
        }
    }
}
