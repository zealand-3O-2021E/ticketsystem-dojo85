﻿using System;

namespace StoreBaeltTicketLibrary
{
    public class Car : ClassLibraryTicketSystem.Car
    {
        public Car(bool brobizz)
        {
            HasBrobizz = brobizz;
        }
        public Car()
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
    }
}
