﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvoiceSummary.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace InvoiceGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InvoiceSummary
    {
        InvoiceGenrator invoiceGenrator = new InvoiceGenrator();

        public int Get_All_Ride(List<Ride> rides)
        {
            return rides.Count;
        }

        public double Total_Fare(List<Ride> rides)
        {
            double totalFare = invoiceGenrator.calculate_Multi_Ride_Fare("normal",rides);
            return totalFare;
        }

        public int Average_Fare_Per_Ride(List<Ride> rides)
        {
            int averageFare = (int)Total_Fare(rides) / Get_All_Ride(rides);
            return averageFare;
        }


    }
}
