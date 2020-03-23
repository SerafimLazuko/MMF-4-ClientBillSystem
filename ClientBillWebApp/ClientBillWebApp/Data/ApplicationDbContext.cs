using System;
using System.Collections.Generic;
using System.Text;
using ClientBillWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClientBillWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<BillModel> Bills { get; set; }
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<CreditCardModel> CreditCards { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<TransferModel> Transfers{ get; set; }
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
