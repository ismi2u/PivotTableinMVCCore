using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PivotTableinMVCCore.Models
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
        {

        }

       public DbSet<Invoice> GetInvoices { get; set; }

        public DbSet<Capacity> Capacities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>().HasData(
                 new Invoice() { InvoiceNumber = 1, Amount = 10, CostCategory = "testing", Period = "2019_11" },
                new Invoice() { InvoiceNumber = 2, Amount = 20, CostCategory = "sales2", Period = "2019_11" },
                new Invoice() { InvoiceNumber = 3, Amount = 30, CostCategory = "testing", Period = "2019_12" },
                new Invoice() { InvoiceNumber = 4, Amount = 40, CostCategory = "sales4", Period = "2019_12" },
                new Invoice() { InvoiceNumber = 5, Amount = 10, CostCategory = "sales2", Period = "2019_11" },
                new Invoice() { InvoiceNumber = 6, Amount = 20, CostCategory = "testing", Period = "2019_11" },
                new Invoice() { InvoiceNumber = 7, Amount = 30, CostCategory = "utilitis", Period = "2019_12" },
                new Invoice() { InvoiceNumber = 8, Amount = 40, CostCategory = "utilitis", Period = "2019_12" }
                );


        }
    }
}
