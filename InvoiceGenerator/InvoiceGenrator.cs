
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvoiceGenrator.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop Kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace InvoiceGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// This class for Generating Fare for ride and generate invoice
    /// </summary>
    public class InvoiceGenrator
    {
        /// <summary>
        /// Cost for perminute ride
        /// </summary>
        private static readonly int COST_PER_MINUTE = 1;
        /// <summary>
        /// Cost for per KiloMeter
        /// </summary>
        private static readonly double MINIMUM_COST_PER_KM = 10;
        /// <summary>
        /// Minimum Fare for ride
        /// </summary>
        private static readonly double MINIMUM_FARE = 5;

        /// <summary>
        /// Method for Calculating single ride fare
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public double calculateFare(Ride ride)
        {
            double totalFare = ride.distance * MINIMUM_COST_PER_KM+ride.time*COST_PER_MINUTE;
            return Math.Max(totalFare,MINIMUM_FARE);
        }
        public double calculate_Multi_Ride_Fare(List<Ride> rides)
        {
            double totalFaire = 0;
            foreach (Ride ride in rides)
            {
                totalFaire = this.calculateFare(ride);
            }

            return totalFaire;

        }
       
    }
}
