using System;

namespace InvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenrator invoice = new InvoiceGenrator();
            Console.WriteLine(invoice.calculateFare(0,1));
        }
    }
}
