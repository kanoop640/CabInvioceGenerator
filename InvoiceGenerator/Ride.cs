using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerator
{
    public class Ride
    {
        public double distance { get; set; }
        public double time { get; set; }

        public Ride( double distance, double time)
        {
            this.distance = distance;
            this.time = time;
        }

    }
}
