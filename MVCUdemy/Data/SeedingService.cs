using MVCUdemy.Models;
using MVCUdemy.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCUdemy.Data
{
    public class SeedingService
    {
        private MVCUdemyContext _context;

        public SeedingService(MVCUdemyContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB already populated
            }
            Department d1 = new Department(1, "Computer");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1,"Bob","bob@email.com",1900.00,new DateTime(1998,02,05),d1);
            Seller s5 = new Seller(4,"Caren","CB@email.com",1950.00,new DateTime(1998,02,05),d1);
            Seller s2 = new Seller(2,"jack dickinson","jack@email.com", 2000.0, new DateTime(1998,06,05),d2);
            Seller s3 = new Seller(3,"Joana","Joana@email.com",2500.00,new DateTime(1999,07,30),d3);
            Seller s6 = new Seller(7,"Jessica Jones","JJ@email.com",2500.00,new DateTime(1999,07,30),d3);
            Seller s4 = new Seller(5,"Rose Mary","Mary@email.com",1994.50,new DateTime(1999,07,30),d4);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 11, 07), SaleStatus.Billed, s1,11000.00);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 05, 07), SaleStatus.Canceled, s4,11500.00);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2020, 01, 25), SaleStatus.Billed, s3,1000.00);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2020, 01, 25), SaleStatus.Pending, s3,1000.00);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2020, 06, 5), SaleStatus.Billed, s3,1000.00);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2020, 01, 25), SaleStatus.Billed, s5,1000.00);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2020, 10, 27), SaleStatus.Pending, s3,1000.00);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2020, 01, 25), SaleStatus.Billed, s3,1000.00);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2020, 01, 25), SaleStatus.Billed, s2,1000.00);
            SalesRecord sr11 = new SalesRecord(12, new DateTime(2020, 8, 03), SaleStatus.Canceled, s3,1000.00);
            SalesRecord sr12 = new SalesRecord(13, new DateTime(2020, 01, 06), SaleStatus.Billed, s2,1000.00);
            SalesRecord sr13= new SalesRecord(14,new DateTime(2020, 01, 08), SaleStatus.Billed, s3,2000.00);
            SalesRecord sr14 = new SalesRecord(15, new DateTime(2020, 01, 06), SaleStatus.Pending, s3,1000.00);
            SalesRecord sr15 = new SalesRecord(16, new DateTime(2020, 01, 25), SaleStatus.Billed, s6,2500.00);
            SalesRecord sr16 = new SalesRecord(17, new DateTime(2020, 02, 05), SaleStatus.Billed, s3,2300.00);
            SalesRecord sr17 = new SalesRecord(18, new DateTime(2020, 09, 25), SaleStatus.Billed, s4,2560.00);
            SalesRecord sr18 = new SalesRecord(19, new DateTime(2020, 01, 25), SaleStatus.Billed, s4,1000.00);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4,s5,s6);
            _context.SalesRecord.AddRange(sr1,sr2,sr4,sr5,sr6,sr7,sr8,sr9,sr10,sr11,sr12,sr13,sr14,sr15,sr16,sr17,sr18);

            _context.SaveChanges();
        }
    }
}
