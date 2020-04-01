using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerator
{
    public class RideRepository
    {
        Dictionary<string, List<Ride>> userRides = new Dictionary<string, List<Ride>>();
        public void AddRides(string userId,List<Ride> rides)
        {
            userRides.Add(userId, rides);
        }
        public int Get_User_Rides(string userId)
        {
            foreach(var userRide in userRides)
            {
                if (userId == userRide.Key)
                {
                    return userRide.Value.Count;
                }
            }
            return default;
        }
    }
}
