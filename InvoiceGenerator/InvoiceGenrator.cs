using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerator
{
    public class InvoiceGenrator
    {
        private static readonly int COST_PER_MINUTE = 1;
        private static readonly double MINIMUM_COST_PER_KM = 10;
        private static readonly double MINIMUM_FARE = 5;

        public double calculateFare(double distance, int time)
        {
            double totalFare = distance * MINIMUM_COST_PER_KM+time*COST_PER_MINUTE;
            return Math.Max(totalFare,MINIMUM_FARE);
        }
    }
}
