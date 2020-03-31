using InvoiceGenerator;
using NUnit.Framework;

namespace InvoiceGeneratorTestCase
{
    public class Tests
    {
        InvoiceGenrator invoiceService = new InvoiceGenrator();
        [Test]
        public void Faire_For_Single_Ride()
        {
            double fare = invoiceService.calculateFare(5, 20);
            Assert.AreEqual(70, fare);
        }
    }
}