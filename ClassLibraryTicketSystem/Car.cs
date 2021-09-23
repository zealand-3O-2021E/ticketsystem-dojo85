using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car
    {
        public string  LicensePlate { get; set; }
        public DateTime Date { get; set; }

        public double Price()
        {
            return 240;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
