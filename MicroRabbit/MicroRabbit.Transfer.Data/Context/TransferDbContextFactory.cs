using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Context
{
    class TransferDbContextFactory : IDesignTimeDbContextFactory<TransferDbContext>
    {
        public TransferDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TransferDbContext>();
            optionsBuilder.UseSqlServer("Server = DESKTOP-198JHES\\SQLEXPRESS; Database = TransferDB; Trusted_Connection=True;MultipleActiveResultSets=true");
            return new TransferDbContext(optionsBuilder.Options);
        }
    }
}
