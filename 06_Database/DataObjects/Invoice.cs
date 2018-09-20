using System;

namespace _06_Database.DataObjects
{
    public class Invoice
    {
        public decimal Cost { get; set; }
        public DateTime BillingDate { get; set; }

        public override string ToString()
        {
            return $"{BillingDate}: {Cost} руб";
        }
    }
}