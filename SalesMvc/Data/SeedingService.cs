using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMvc.Models;
using SalesMvc.Models.Enums;

namespace SalesMvc.Data
{
    public class SeedingService
    {
        private SalesMvcContext _context;

        public SeedingService(SalesMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // O banco de dados já foi populado.
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Alex Blue", "alex@gmail.com", new DateTime(1975, 2, 13), 3000, d2);
            Seller s3 = new Seller(3, "Maria Yellow", "maria@gmail.com", new DateTime(1985, 6, 16), 2000.0, d3);
            Seller s4 = new Seller(4, "Ana Red", "ana@gmail.com", new DateTime(1996, 5, 12), 1500.0, d4);
            Seller s5 = new Seller(5, "Matheus Pink", "matheus@gmail.com", new DateTime(1970, 9, 1), 1800.0, d1);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2019, 09, 23), 1100.0, SaleStatus.Billed, s5);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2019, 10, 12), 700, SaleStatus.Billed, s4);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2020, 1, 3), 7000.0, SaleStatus.Billed, s5);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2021, 9, 23), 100.0, SaleStatus.Billed, s2);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2021, 2, 23), 10100.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5);

            _context.SaveChanges();

        }
    }
}
