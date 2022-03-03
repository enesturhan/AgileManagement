using AgileManagement.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;


namespace AgileManagement.Persistence.EF
{

    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {

        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-G9N5CHK\ENESSQL;Database=AgileManagamentDb;Trusted_Connection=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }




    /// <summary>
    /// Katmanlı mimari ile çalışırken ilgili katmandan migration alma işlemleri vs gibi durumlarda UserDbContextFactory ile dbContext ayağa kaldırılır. Production ortamında gerek kalmaz. Microsoft.EntityFrameworkCore.Design katmanlı mimari de bu paketi indirelim ve aşağıdaki gibi DbContext class olduğu yere IDesignTimeDbContextFactory implemente olan bir FactoryContext yazalım 
    /// ilgili proje katmanını seçip migration uygularız.
    /// </summary>
    public class AppDbContext : IdentityDbContext<UserApp, IdentityRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {

        }

        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(builder);
        }
    }
}
