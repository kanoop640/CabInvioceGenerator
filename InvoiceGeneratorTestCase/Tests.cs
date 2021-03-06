// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tests.cs" company="Bridgelabz">
//   Copyright � 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace InvoiceGeneratorTestCase
{
    using InvoiceGenerator;
    using NUnit.Framework;
    using System.Collections.Generic;
    public class Tests
    {
        /// <summary>
        /// InvoiceGenerator class object
        /// </summary>
        InvoiceGenrator invoiceService = new InvoiceGenrator();
        /// <summary>
        /// InvoiceSummary class object
        /// </summary>
        InvoiceSummary invoiceSummary = new InvoiceSummary();
        /// <summary>
        /// List for storing ride information
        /// </summary>
        List<Ride> rides = new List<Ride>();
        /// <summary>
        /// Test Case for Single Ride 
        /// Step 1
        /// </summary>
        [Test]
        public void Fare_For_Single_Ride()
        {
            double fare = invoiceService.calculateFare("normal",new Ride(10,5));
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
            double fare = invoiceService.calculate_Multi_Ride_Fare("normal",rides);
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
        /// <summary>
        /// Test Case Step 4
        /// This test case for getting rides form given userId
        /// form ride repo
        /// </summary>
        [Test]
        public void Given_UserId_Summar_Should_Return_Rides()
        {
            List<Ride> rides = new List<Ride> { 
                new Ride(4,2),
                new Ride(8,20),
                new Ride(15,25)};
            invoiceService.AddRides("Anoop", rides);
            Assert.AreEqual(invoiceService.GetRides("Anoop"),rides.Count);
        }
        /// <summary>
        /// cost for single premium ride cost
        /// </summary>
        [Test]
        public void Fare_For_Premium_Single_Ride()
        {
            Assert.AreEqual(invoiceService.calculateFare("premium", new Ride(10, 5)), 160);
        }
    }
}