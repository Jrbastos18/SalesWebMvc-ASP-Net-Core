using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecords
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Satus { get; set; }
        public Seller Seller { get; set; }

        public SalesRecords()
        {
        }

        public SalesRecords(int id, DateTime date, double amount, SalesStatus satus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Satus = satus;
            Seller = seller;
        }
    }
}
