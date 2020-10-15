using System;
namespace InvoiceTest
{
    public class Invoice
    {
         private string number;
         private string description;

         private int quantity;
         private decimal price;

        public string Number{
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
          }

        public string Description{
                get 
                {
                    return description;
                }
                set
                {
                    description = value;
                }
            
            }

        public int Quantity
            {
                get {
                    return quantity;
                }
                set
                {
                    if (value < 0.0M )
                    {
                        quantity = 0;
                    } else {
                        quantity = value;
                    }
                }
            }

        public decimal Price
            {
                get 
                {
                    return price;
                }
                set
                {
                        if (value < 0.0M)
                    {
                        price = 0;
                    } else {
                        price = value;
                    }
                }
            }
            public decimal GetInvoiceAmount()
            {
            return Quantity * Price;
            }
    }  
}

    