using InvoiceGenerator;
using NUnit.Framework;
using System.Collections.Generic;

namespace InvoiceGeneratorTestCase
{
    public class Tests
    {
        InvoiceGenrator invoiceService = new InvoiceGenrator();
        InvoiceSummary invoiceSummary = new InvoiceSummary();
        List<Ride> rides = new List<Ride>();
        /// <summary>
        /// Test Case for Single Ride 
        /// Step 1
        /// </summary>
        [Test]
        public void Fare_For_Single_Ride()
        {
            double fare = invoiceService.calculateFare(new Ride(10,5));
            Assert.AreEqual(105, fare);
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
        /// <summary>
        /// Findout Total Number of Rides Done
        /// </summary>
        [Test]
        public void Total_Number_Of_Rides()
        {
            rides.Add(new Ride(5, 3));
            rides.Add(new Ride(5, 3));
            rides.Add(new Ride(5, 3));
            rides.Add(new Ride(5, 3));
            rides.Add(new Ride(5, 3));
            Assert.AreEqual(invoiceSummary.Get_All_Ride(this.rides), rides.Count);

        }
        /// <summary>
        /// Method for Total Fare
        /// </summary>
        [Test]
        public void Total_Fairs()
        {
            rides.Add(new Ride(5, 3));
            rides.Add(new Ride(10, 6));
            rides.Add(new Ride(1, 15));
            rides.Add(new Ride(6, 2));
            rides.Add(new Ride(20, 9));
            Assert.AreEqual(invoiceSummary.Total_Fare(rides), 209);
        }
        /// <summary>
        /// Average Fare for per ride
        /// </summary>
        [Test]
        public void Average_Fare_Per_Ride()
        {
            rides.Add(new Ride(5, 3));
            rides.Add(new Ride(10, 6));
            rides.Add(new Ride(1, 15));
            rides.Add(new Ride(6, 2));
            rides.Add(new Ride(20, 9));
            Assert.AreEqual(invoiceSummary.Average_Fare_Per_Ride(rides), 41);
        }
    }
}