using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Represents a vehicle of type: Motorcycle
    /// </summary>
    public class MC : Vehicle
    {
        protected override double TicketPrice => 125;
        protected override string Type => "MC";
    }
}
