using System;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice ();
            Console.Write("Please enter the quantity you want in numbers: ");
            invoice.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the price: ");
            invoice.Price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"The amount of the invoice of {invoice.Quantity} and {invoice.Price} is: {invoice.GetInvoiceAmount():C}");
        }
    }
}
