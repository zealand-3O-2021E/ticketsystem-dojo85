using System;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// This car class is specific for the Storebaelt company and is adjusted to their
    /// requirements concerning weekend discount.
    /// </summary>
    public class StorebaeltCar : ClassLibraryTicketSystem.Car
    {
        private bool _isWeekend = false;

        public StorebaeltCar(string license, DateTime date, bool brobizz = false)
        {
            LicensePlate = license;
            Date = date;
            HasBrobizz = brobizz;
        }
        public StorebaeltCar()
        {

        }

        /// <summary>
        /// This method is specific to the Storebaelt requirements:
        /// On weekends, a discount of 20% is granted. 
        /// An eventual Brobizz discount is deducted after the weekend discount.
        /// </summary>
        /// <returns>The total price after including all eventual discounts.</returns>
        public override double Price()
        {
            int weekday = (int)Date.DayOfWeek;
            double price = TicketPrice;

            if (weekday == 0 || weekday == 6)
            {
                price = GetWeekendDiscount(price);
                _isWeekend = true;
            }

            if (HasBrobizz)
            {
                price = GetBrobizzDiscount(price);
            }

            return price;
        }

        /// <summary>
        /// This method calculates the weekend discount.
        /// </summary>
        /// <param name="price"></param>
        /// <returns>The amount of the weekend discount.</returns>
        private double GetWeekendDiscount(double price)
        {
            return price - CalculatePercents(price, 20);
        }

        /// <summary>
        /// This method calculates the Brobizz discount.
        /// </summary>
        /// <param name="price"></param>
        /// <returns>The amount of the Brobizz discount.</returns>
        private double GetBrobizzDiscount(double price)
        {
            return price - CalculatePercents(price, 5);
        }

        /// <summary>
        /// Helpter mehtod to calculate a certain percentage of another number.
        /// </summary>
        /// <param name="baseValue">The base value of which to calculate the percentage.</param>
        /// <param name="percentage">Percent</param>
        /// <returns>The required percentage of the base value as double.</returns>
        private double CalculatePercents(double baseValue, double percentage)
        {
            return (baseValue/100) * percentage;
        }

        /// <summary>
        /// Description of this object.
        /// </summary>
        /// <returns>Vehicle type, License plate, Date, Price, BroBizz usage, Weekend discount</returns>
        public override string ToString()
        {
            if (_isWeekend)
            {
                return base.ToString() + $", Weekend discount";
            }
            return base.ToString();
        }
    }
}
