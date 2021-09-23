using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Represents a vehicle of type: Motorcycle
    /// </summary>
    public class MC : Vehicle
    {
        public MC(bool brobizz)
            : base(brobizz)
        {
            HasBrobizz = brobizz;
        }

        public MC()
        {
        }

        protected override double TicketPrice => 125;
        protected override string Type => "MC";
    }
}
