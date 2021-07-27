using System;

namespace InvoiceReader
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceTotal { get; set; }

        public Invoice(int invoiceId, DateTime invoiceDate, decimal invoiceTotal)
        {
            InvoiceId = invoiceId;
            InvoiceDate = invoiceDate;
            InvoiceTotal = invoiceTotal;
        }
    }
}