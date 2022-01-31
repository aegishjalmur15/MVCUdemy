using MVCUdemy.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCUdemy.Models
{
    public class SalesRecord
    {
        public SalesRecord()
        {

        }
        public SalesRecord(int id, DateTime date, SaleStatus status, Seller seller, double amount)
        {
            Id = id;
            Date = date;
            Status = status;
            Amount = amount;
            Seller = seller;
        }

        public int Id { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public SaleStatus Status { get; set; }

        [DisplayFormat(DataFormatString ="{0:f2}")]
        public double Amount { get; set; }
        public Seller Seller { get; set; }
    }
}
