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
        public Car(bool brobizz)
            :base(brobizz)
        {
            HasBrobizz = brobizz;
        }

        public Car()
        {
        }

        protected override double TicketPrice => 240;
        protected override string Type => "Car";
    }
}
