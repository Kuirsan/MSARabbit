using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Context
{
    class BankingDbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDbContext>();
            optionsBuilder.UseSqlServer("Server = DESKTOP-198JHES\\SQLEXPRESS; Database = BankingDB; Trusted_Connection=True;MultipleActiveResultSets=true");
            return new BankingDbContext(optionsBuilder.Options);
        }
    }
}
