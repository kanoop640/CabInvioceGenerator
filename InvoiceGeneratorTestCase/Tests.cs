using InvoiceGenerator;
using NUnit.Framework;
using System.Collections.Generic;

namespace InvoiceGeneratorTestCase
{
    public class Tests
    {
        InvoiceGenrator invoiceService = new InvoiceGenrator();
        /// <summary>
        /// Test Case for Single Ride 
        /// Step 1
        /// </summary>
        [Test]
        public void Fare_For_Single_Ride()
        {
            double fare = invoiceService.calculateFare(5, 20);
            Assert.AreEqual(70, fare);
        }
        /// <summary>
        /// Test Case for Multi Ride
        /// Step 2
        /// </summary>
        [Test]
        public void Fare_For_Multi_Ride()
        {
            List<Ride> rides = new List<Ride> {new Ride(10,5),new Ride(9,15) };
            double fare = invoiceService.calculate_Multi_Ride_Fare(rides);
            Assert.AreEqual(fare, 105);
        }
    }
}