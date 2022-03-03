using AgileManagement.Domain;
using AgileManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Persistence.EF
{

    //public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContextEski>
    //{

    //    public AppDbContextEski CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<AppDbContextEski>();
    //        optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=AgileManagementDb;Trusted_Connection=true");

    //        return new AppDbContext(optionsBuilder.Options);
    //    }
    //}

    //public class AppDbContextEski : IdentityDbContext<UserApp, IdentityRole, string>
    //{
    //    public AppDbContextEski(DbContextOptions<AppDbContextEski> options) : base(options)

    //    {
    //    }

    //    public DbSet<Product> Produts { get; set; }

    //    public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

    //    protected override void OnModelCreating(ModelBuilder builder)
    //    {
    //        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

    //        base.OnModelCreating(builder);
    //    }
    //}

}
