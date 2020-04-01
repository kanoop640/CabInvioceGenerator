
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
        private static readonly int PREMIUM_RIDE_COST_PER_MINUTE = 2;
        private static readonly double PREMIUM_RIDE_MINIMUM_COST = 20;
        private static readonly double PREMIUM_RIDE_PER_KM_COST = 15;

       RideRepository rideRepository = new RideRepository();

        /// <summary>
        /// Method for Calculating single ride fare
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public double calculateFare(string typeOfRide, Ride ride)
        {
            double totalFare = 0;
            if (typeOfRide == "premium")
            {
               totalFare = ride.distance * PREMIUM_RIDE_PER_KM_COST + ride.time * PREMIUM_RIDE_COST_PER_MINUTE;
                return Math.Max(totalFare, PREMIUM_RIDE_PER_KM_COST);
            }
            totalFare = ride.distance * MINIMUM_COST_PER_KM+ride.time*COST_PER_MINUTE;
            return Math.Max(totalFare,MINIMUM_FARE);
        }
        public double calculate_Multi_Ride_Fare(string  typeOfRide, List<Ride> rides)
        {
            double totalFaire = 0;
            foreach (Ride ride in rides)
            {
                totalFaire = this.calculateFare(typeOfRide,ride);
            }

            return totalFaire;

        }
        /// <summary>
        /// Add Rides with userId Add into list
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="rides"></param>
        public void AddRides(string userId, List<Ride> rides)
        {
            rideRepository.AddRides(userId, rides);
        }
        /// <summary>
        /// Get number of ride from given userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int GetRides(string userId)
        {
            return rideRepository.Get_User_Rides(userId);
        }
       
    }
}
