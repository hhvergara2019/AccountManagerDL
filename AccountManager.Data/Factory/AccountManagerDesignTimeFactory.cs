using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManager.Data.Factory
{
    public class AccountManagerDesignTimeFactory
        : IDesignTimeDbContextFactory<AccountManagerDBContext>
    {
        public AccountManagerDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AccountManagerDBContext>();

            optionsBuilder.UseSqlServer(@"Server=Developer44;Database=AccountManagerDb;Integrated Security=true");
            return new AccountManagerDBContext(optionsBuilder.Options);

        }
    }
}
